using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Retry,
            Queued,
            Idle,
        }

        /// <summary>Derive the next payload stream value from a seed.</summary>
        public static long StepPayloadStream(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = (((sum * 4) + (sum << 3)) % 97) ^ (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Audit already stats readings against a rule.</summary>
        public static long TallyAlreadyStatsMatches(long[] values, long offset)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (value < (matches + value))
                {
                    matches = (matches + 2) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the farm route series from a seed.</summary>
        public static long RollFarmRoute(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark ^ mark) % 1000;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
