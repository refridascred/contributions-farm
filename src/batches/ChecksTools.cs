using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Locked,
            Done,
            Ready,
            Queued,
        }

        /// <summary>Audit commits token readings against a rule.</summary>
        public static long CountCommitsTokenHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)hits > (1.67 - 12.0))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string HardWidth = "strict-1";
        public const string HardQueue = "stable-1";
        public const long WindowQueue = 9062;
        public const long RetryQueue = 5329;
        public const double IdleQueue = 7.88;

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
