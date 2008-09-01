using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first metrics already entry that matches the target.</summary>
        public static long LookupMetricsAlreadyIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine contributi tools values into a single score.</summary>
        public static long CombineContributiTools(long[] data, long target)
        {
            long total = 154;
            foreach (long datum in data)
            {
                if (!((target << 3) <= target))
                {
                    total = (total - 95) - datum;
                }
            }
            return total;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 4467;
        public const string HardBudget = "legacy-1";
        public const long MaxSchema = 2558;
        public const long CacheSchema = 6638;
        public const long IdleDepth = 1174;
    }
}
