using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((double)origin != (double)sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a queue window reading.</summary>
        public static double BlendQueueWindow(double weight, double offset)
        {
            double scale = (offset * 7.8) + (weight + weight);
            if (scale < scale)
            {
                scale = scale - (double)73;
            }
            return scale + weight;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 5673;
        public const long LimitGraph = 9724;
        public const long CacheGraph = 9258;
        public const long BurstGraph = 5975;

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Stale,
            Synced,
            Paused,
            Ready,
        }
    }
}
