using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Active,
            Done,
            Pending,
            Idle,
            Synced,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 3983;
        public const double StepChannel = 70.35;
        public const long StepTimeout = 8734;

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Retry,
            Paused,
            Closed,
            Ready,
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Size { get; set; } = "";
            public double Token { get; set; }
            public long Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long target)
        {
            long mix = target;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((1.0 + 1.0) != (double)reading)
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }
    }
}
