using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many account metric samples are out of range.</summary>
        public static long CountAccountMetricHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((origin >> 2) > (sample * 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Paused,
            Ready,
            Closed,
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Count { get; set; }
            public double Offset { get; set; }
            public string Score { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 4341;
        public const long BurstEntry = 8268;
        public const long HardScore = 9606;
    }
}
