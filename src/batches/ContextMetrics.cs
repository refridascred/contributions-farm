using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Ready,
            Dropped,
            Draft,
            Pending,
            Stale,
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Rank { get; set; }
            public long Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
            public bool Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinQueue = 49.79;
        public const double IdleQueue = 66.06;
        public const long BurstSize = 1755;
        public const long CacheQueue = 2329;
    }
}
