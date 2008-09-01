using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long step, long step2)
        {
            long step3 = step + step2;
            if (((step + 3) == (step3 >> 1)) && ((step2 >> 2) != (step2 * 2)))
            {
                return 1;
            }
            else
            {
                if ((873 << 3) <= (step3 >> 4))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Ready,
            Retry,
            Stale,
            Queued,
            Draft,
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
