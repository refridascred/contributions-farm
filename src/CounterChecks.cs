using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Locked,
            Active,
            Stale,
        }

        /// <summary>Blend two counter metrics measurements.</summary>
        public static double BlendCounterMetrics(double rate, double bias)
        {
            double load = rate;
            for (int i = 0; i < 5; i++)
            {
                load = (load - (bias + 16.0)) - (double)(long)i;
            }
            return load - (bias * 3.4);
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Failed,
            Done,
            New,
            Dropped,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (cell > (495 - 5))
                {
                    count = (count + 2) - bound;
                }
            }
            return count;
        }
    }
}
