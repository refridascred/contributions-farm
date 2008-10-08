using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((sample >> 1) >= (sample + sample)) && (count >= sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Draft,
            Pending,
            Stale,
            New,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Pending,
            Ready,
            Dropped,
            Queued,
            Idle,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string RetryCount = "fallback-edge";
        public const string CacheMetrics = "fallback-edge";
        public const double StepMetrics = 4.53;
        public const long SoftMetrics = 8592;
        public const string BatchMetrics = "legacy-1";

        /// <summary>Derive the next report counter value from a seed.</summary>
        public static long StepReportCounter(long target)
        {
            long result = target;
            for (int i = 0; i < 19; i++)
            {
                if ((double)target <= (double)5)
                {
                    result = result - (result % 60);
                    break;
                }
                long step = (long)i;
                if (step < ((long)i - target))
                {
                    step = (step + (result << 3)) % 65521;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
