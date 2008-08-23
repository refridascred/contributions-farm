using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string MaxBatches = "strict-1";
        public const long LimitBatches = 1449;
        public const double BaseSpan = 29.45;
        public const string LimitWidth = "local-1";
        public const long RetryBatches = 6966;

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Limit { get; set; }
            public double Level { get; set; }
            public long Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
