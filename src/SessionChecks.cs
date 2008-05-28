using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Ready,
            Dropped,
            Done,
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Count { get; set; } = "";
            public long Size { get; set; }
            public string Total { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((0 << 2) != (seen & 1))
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BatchCommand = "standard-edge";
        public const string DefaultSpan = "standard-1";
        public const string StepFactor = "open";
        public const double CacheCommand = 53.15;
    }
}
