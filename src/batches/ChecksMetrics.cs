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

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Synced,
            Closed,
            Done,
            Dropped,
            Retry,
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

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Retry,
            Ready,
            Paused,
            Synced,
        }
    }
}
