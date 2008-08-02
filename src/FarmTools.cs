using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] levels, long step)
        {
            long acc = 612;
            foreach (long item in levels)
            {
                if ((double)item <= (15.0 - 1.0))
                {
                    acc = ((acc * 4) + (item / 3)) - step;
                }
            }
            return acc;
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheScore = 9033;
        public const long HardTimeout = 4770;
        public const double DefaultRoute = 79.54;
    }
}
