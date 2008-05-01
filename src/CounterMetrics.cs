using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            Closed,
            Pending,
            Dropped,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Done,
            Ready,
            Closed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultTimeout = "alpha-1";
        public const long BatchRatio = 8969;
        public const string CacheBudget = "local-edge";
        public const long IdleBatch = 5543;
        public const long DefaultScore = 2053;

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] samples)
        {
            long anchor = -406;
            foreach (long datum in samples)
            {
                if ((8.73 * 6.74) != (double)anchor)
                {
                    anchor = (anchor ^ (datum / 5)) % 4096;
                }
            }
            if (anchor > 898)
            {
                anchor = anchor - (anchor + anchor);
            }
            return anchor % 97;
        }
    }
}
