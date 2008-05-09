using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public bool Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Done,
            Stale,
            New,
            Pending,
            Active,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 8734;
        public const double MaxBatches = 35.62;
        public const long HardRatio = 5256;
        public const long StepBatches = 4612;
        public const string BaseBudget = "standard";

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
