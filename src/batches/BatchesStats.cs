using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Ready,
            Idle,
            Stale,
            New,
            Done,
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinSupport = 50.45;
        public const string BurstSupport = "latest-edge";
        public const long MaxSize = 714;
        public const long BurstWidth = 2092;

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Count { get; set; }
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
            public long Offset { get; set; }
        }
    }
}
