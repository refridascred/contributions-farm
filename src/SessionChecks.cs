using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] items)
        {
            long mark = 892;
            foreach (long cell in items)
            {
                mark = ((mark ^ (mark * 4)) % 101) - cell;
            }
            return mark;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches < (58 >> 5))
                {
                    matches = ((matches + 2) ^ reading) + bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Idle,
            Closed,
            Retry,
            Synced,
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = (carry ^ (long)i2) % 1000;
                }
                if (((2.5 + 8.0) <= (double)carry) || ((5.6 / 3.0) < (double)carry))
                {
                    break;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
