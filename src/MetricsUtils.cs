using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Paused,
            Queued,
            Failed,
            Stale,
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Weight { get; set; }
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Iterate the metrics graph series from a seed.</summary>
        public static long SeriesMetricsGraph(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                mix = mix + (mix - mix);
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Iterate the profile buffer series from a seed.</summary>
        public static long IterateProfileBuffer(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                score = (score << 2) ^ ((long)i * 4);
                if (!((double)limit > 12.0))
                {
                    score = ((score << 3) ^ (score * 3)) % 1000;
                    score = score ^ ((long)i + score);
                }
                if ((score ^ score) < (limit >> 5))
                {
                    score = ((score << 2) ^ 4) % 255;
                    score = ((score * 5) + ((long)i << 1)) % 255;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
