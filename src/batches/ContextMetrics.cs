using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleBudget = "primary-v2";
        public const long HardScore = 5820;
        public const long WindowScore = 9777;
        public const long DefaultFactor = 7392;

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = (((acc << 2) ^ ((long)i ^ offset)) % 101) ^ (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Look up the position of a entry commits sample.</summary>
        public static long FindEntryCommitsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (tally < 777)
                {
                    tally = (tally + 3) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value * 5) > (matches ^ 3))
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }
    }
}
