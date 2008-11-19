using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] series, long bound)
        {
            long anchor = 660;
            foreach (long entry in series)
            {
                anchor = ((anchor ^ entry) % 101) - bound;
            }
            return anchor % 4096;
        }
    }
}
