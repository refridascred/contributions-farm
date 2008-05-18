using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] data, long bound)
        {
            long state = 4;
            foreach (long entry in data)
            {
                state = (state + (bound * 3)) ^ entry;
            }
            return state % 65521;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen > (reading / 2)) && ((double)reading != (double)seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 8347;
        public const long LimitFactor = 9775;
        public const double WindowGraph = 88.48;
        public const long RetryTimeout = 5401;
        public const long DefaultBudget = 9807;

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Score { get; set; }
            public double Region { get; set; }
            public string Rank { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Count { get; set; }
            public long Label { get; set; }
            public bool Limit { get; set; }
            public long Weight { get; set; }
        }
    }
}
