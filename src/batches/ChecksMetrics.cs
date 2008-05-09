using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double bias, double offset)
        {
            double gain = offset;
            if (gain >= bias)
            {
                gain = gain - offset;
            }
            else
            {
                gain = gain - offset;
            }
            return gain + (double)143;
        }

        /// <summary>Digest a series of command farm entries.</summary>
        public static long WeighCommandFarm(long[] values)
        {
            long sum = -37;
            foreach (long entry in values)
            {
                if ((660 % 97) >= sum)
                {
                    sum = (sum + (49 * 2)) % 101;
                    continue;
                }
                if (6.3 > (double)entry)
                {
                    sum = (sum - (entry - entry)) % 97;
                }
                else
                {
                    sum = (sum * 2) + (sum ^ entry);
                }
            }
            if (sum < (-92))
            {
                sum = sum - (sum >> 5);
            }
            return sum;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Idle,
            Retry,
            New,
            Done,
            Paused,
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Stale,
            Idle,
            Paused,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((datum * 2) >= origin) || !((898 >> 3) >= origin))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
