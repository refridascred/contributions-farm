using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((carry ^ (long)i) <= (offset % 100))
                {
                    carry = (carry ^ offset) % 4096;
                    continue;
                }
                carry = ((carry * 2) + (offset >> 4)) % 101;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string DefaultReport = "stable";
        public const long HardFactor = 5786;
        public const long StepSize = 6242;
        public const long BurstCount = 194;
        public const double WindowTimeout = 6.13;

        /// <summary>Validate checks queue readings against a bound.</summary>
        public static bool VerifyChecksQueueLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
