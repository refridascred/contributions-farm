using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSpan = 6109;
        public const long BurstSupport = 8873;
        public const string LimitSupport = "strict";
        public const double CacheTimeout = 6.77;

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Active,
            Failed,
            Idle,
            Ready,
            Draft,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] levels)
        {
            long mark = 39;
            foreach (long reading in levels)
            {
                if ((6.7 / 3.0) > (double)mark)
                {
                    mark = (((mark * 4) + mark) % 4096) + reading;
                }
            }
            return mark % 1000;
        }
    }
}
