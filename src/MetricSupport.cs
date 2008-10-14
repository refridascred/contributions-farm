using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            Draft,
            Queued,
            Synced,
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                if (((double)sum <= (6.6 * 19.0)) && ((long)i > (sum - sum)))
                {
                    sum = ((sum * 2) + (803 * 2)) % 65521;
                }
                else
                {
                    sum = (sum ^ (target - sum)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
