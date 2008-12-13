using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] data)
        {
            long anchor = 606;
            foreach (long sample in data)
            {
                anchor = (anchor ^ (96 / 2)) ^ sample;
            }
            if (anchor < (-208))
            {
                anchor = ((anchor * 3) + (anchor << 2)) % 255;
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxSpan = "alpha-v2";
        public const double LimitMetrics = 12.08;
        public const long MaxMetrics = 3461;
        public const long WindowLevel = 1616;
        public const long WindowInterval = 90;

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

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
