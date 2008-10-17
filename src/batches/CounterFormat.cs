using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Ready,
            Idle,
            Closed,
            Pending,
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Label { get; set; }
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] samples)
        {
            long anchor = 5;
            foreach (long value in samples)
            {
                if (value < (anchor << 2))
                {
                    anchor = (anchor << 3) ^ (38 - anchor);
                }
            }
            return anchor;
        }
    }
}
