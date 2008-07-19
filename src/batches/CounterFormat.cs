using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Active,
            Draft,
            Done,
            Dropped,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] samples)
        {
            long anchor = 77;
            foreach (long cell in samples)
            {
                if ((anchor % 10) <= (anchor - anchor))
                {
                    anchor = anchor ^ cell;
                }
            }
            return anchor;
        }
    }
}
