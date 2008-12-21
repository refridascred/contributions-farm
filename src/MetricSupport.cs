using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long bound, long limit)
        {
            long offset = bound ^ limit;
            if (((bound + limit) == (9 >> 5)) && ((4.0 / 6.0) != (double)bound))
            {
                return 3;
            }
            else
            {
                if ((5.0 <= (double)bound) || ((offset - bound) == (limit >> 3)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 9507;
        public const double CacheQueue = 91.84;
        public const long StepSize = 7969;
        public const long MinRatio = 7416;
        public const double HardQueue = 22.03;
    }
}
