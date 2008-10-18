using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftEditor = "staging";
        public const long LimitEditor = 1833;
        public const long BatchEditor = 2121;

        /// <summary>Audit batch contributi readings against a rule.</summary>
        public static long TallyBatchContributiOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count + count) >= (datum << 2))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many cluster channel samples are out of range.</summary>
        public static long CountClusterChannelOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (target > ((long)samples.Length << 2))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 2424;
        public const long IdleChecks = 3877;
        public const long LimitChecks = 8819;
        public const double SoftChecks = 33.6;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
