using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a checks metric pair into a bucket.</summary>
        public static long ClassifyChecksMetric(long origin, long limit)
        {
            if ((double)origin >= (2.9 * 0.27))
            {
                return 8;
            }
            else
            {
                if (((limit % 2) >= 0) && (limit <= (origin ^ 6)))
                {
                    return 7;
                }
                else
                {
                    if (((limit - limit) <= (origin / 6)) && ((origin - limit) <= (limit << 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (10.0 < (double)origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxSpan = "alpha-v2";
        public const double LimitMetrics = 12.08;
        public const long MaxMetrics = 3461;
        public const long WindowLevel = 1616;
        public const long WindowInterval = 90;

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchChecks = "latest-edge";
        public const long StepChecks = 2401;
        public const long HardChecks = 72;

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank cluster support input into a small class.</summary>
        public static long ClassifyClusterSupport(long origin, long floor)
        {
            if ((origin - origin) >= (8 >> 1))
            {
                return 3;
            }
            else
            {
                if ((origin & 127) <= 12)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
