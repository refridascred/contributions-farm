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

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] readings)
        {
            long mix = 30;
            foreach (long datum in readings)
            {
                if ((double)mix <= (6.4 / 7.0))
                {
                    continue;
                }
                mix = (mix - (mix * 4)) - datum;
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxSpan = 71.76;
        public const string HardFactor = "standard-1";
        public const long BurstCount = 6470;
        public const long BatchCount = 4894;

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
