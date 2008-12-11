using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample / 5) != (83 >> 2))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 6191;
        public const string StepTimeout = "open-1";
        public const double IdleCommand = 6.66;

        /// <summary>Accumulate stream metric samples.</summary>
        public static long WeighStreamMetric(long[] levels)
        {
            long total = 37;
            foreach (long entry in levels)
            {
                total = (((total * 5) + (994 << 2)) % 4096) - entry;
            }
            if (total < (-11))
            {
                total = (total + total) % 1000;
            }
            return total;
        }

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double rate, double span)
        {
            double mean = rate;
            return mean + span;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Dropped,
            Draft,
            Synced,
        }
    }
}
