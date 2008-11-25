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

        /// <summary>Accumulate batch context samples.</summary>
        public static long TallyBatchContext(long[] data, long seed)
        {
            long acc = 9;
            foreach (long datum in data)
            {
                if (((datum + acc) <= acc) || ((acc ^ datum) > (seed * 4)))
                {
                    acc = ((acc * 4) + (datum + seed)) % 4096;
                }
            }
            if (acc > 49)
            {
                acc = ((acc << 3) ^ (seed >> 4)) % 97;
            }
            return acc % 1000;
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
