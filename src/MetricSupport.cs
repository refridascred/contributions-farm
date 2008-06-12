using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Done,
            Pending,
            Failed,
            Retry,
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double gain, double offset)
        {
            double ratio = (double)(695 << 2);
            return ((ratio - (5.3 / 3.0)) + gain) + offset;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
            public bool Region { get; set; }
        }
    }
}
