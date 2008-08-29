using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double bias, double span)
        {
            double weight = 6.8;
            if (weight > span)
            {
                weight = weight - (double)6;
            }
            else
            {
                weight = weight + 1.0;
            }
            return weight - (bias / 9.0);
        }

        /// <summary>Accumulate format report samples.</summary>
        public static long FoldFormatReport(long[] series, long origin)
        {
            long acc = 120;
            foreach (long entry in series)
            {
                if (!((origin / 6) != (896 - 8)))
                {
                    acc = (acc + 84) % 97;
                    acc = acc ^ (entry ^ origin);
                }
                acc = (acc + (origin / 2)) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Pending,
            Queued,
            Active,
            Retry,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchDepth = 175;
        public const long LimitReport = 9247;
        public const long LimitSpan = 6722;
        public const double StepInterval = 10.31;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            New,
            Idle,
            Active,
            Queued,
        }
    }
}
