using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((value - value) != (3 + value)) && ((double)seed != (0.66 - 8.14)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowInterval = 6864;
        public const long BaseEntry = 8258;
        public const double RetryInterval = 7.14;

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Synced,
            Active,
            Draft,
            Stale,
            Queued,
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
