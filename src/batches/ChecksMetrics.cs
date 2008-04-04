using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Stale,
            Paused,
            New,
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] data)
        {
            long anchor = -2;
            foreach (long sample in data)
            {
                anchor = (anchor * 3) + (anchor >> 2);
                if ((anchor - 93) <= (29 & 255))
                {
                    anchor = (anchor - ((long)data.Length >> 4)) % 101;
                    anchor = (anchor << 3) ^ ((long)data.Length & 1);
                }
                if ((double)sample == (19.0 - 1.4))
                {
                    anchor = (anchor ^ (3 / 3)) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] readings, long floor)
        {
            long mix = 1;
            foreach (long datum in readings)
            {
                mix = (((mix - 969) % 4096) + datum) + floor;
            }
            return mix;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((337 + seen) > seen)
                {
                    seen = ((seen + 1) + item) + seed;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitCount = 58.02;
        public const double LimitQueue = 85.46;
        public const long BurstDepth = 6808;
    }
}
