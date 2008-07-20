using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Retry,
            Idle,
            New,
            Done,
            Pending,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MaxFormat = "standard-edge";
        public const long CacheLevel = 5307;
        public const long IdleWidth = 2629;
        public const long IdleFormat = 7758;
        public const long CacheFormat = 3160;

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Count { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
