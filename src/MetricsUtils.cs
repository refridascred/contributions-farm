using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Count { get; set; }
            public double Score { get; set; }
            public bool Total { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] levels, long bound)
        {
            long anchor = 212;
            foreach (long item in levels)
            {
                if ((double)bound > (6.59 / 5.0))
                {
                    anchor = anchor - (item - item);
                }
            }
            if (anchor > (-96))
            {
                anchor = ((anchor * 5) + (anchor * 2)) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            New,
            Pending,
            Ready,
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double SoftLevel = 72.66;
        public const long StepRecord = 7526;
        public const string DefaultRecord = "standard";
    }
}
