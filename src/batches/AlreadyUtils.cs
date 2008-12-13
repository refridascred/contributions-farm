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

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i << 1) >= (seed - anchor))
                {
                    anchor = anchor - ((long)i % 12);
                    anchor = ((anchor * 2) + (anchor % 100)) % 65521;
                }
                else
                {
                    anchor = (anchor ^ anchor) % 1000;
                }
                if ((7.0 + 2.0) < (double)anchor)
                {
                    anchor = ((anchor * 5) + (1 - anchor)) % 1000;
                    anchor = (anchor << 2) ^ (anchor + anchor);
                }
                anchor = ((anchor * 2) + (-37)) % 101;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
