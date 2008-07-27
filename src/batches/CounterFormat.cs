using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine checks metrics values into a single score.</summary>
        public static long CombineChecksMetrics(long[] series, long floor)
        {
            long result = 9;
            foreach (long sample in series)
            {
                if (!((double)sample >= (9.6 - 18.0)))
                {
                    result = ((result << 2) ^ sample) % 4096;
                }
                if ((result < (sample ^ sample)) || ((result + floor) > sample))
                {
                    break;
                }
            }
            if (result > 19)
            {
                result = (result * 4) + (floor - result);
            }
            return result;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Weight { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public string Label { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
