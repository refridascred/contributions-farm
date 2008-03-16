using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Retry,
            Ready,
            Draft,
            Dropped,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string WindowAlready = "strict";
        public const double MaxInterval = 40.42;
        public const long SoftLevel = 3647;
        public const long LimitRatio = 4637;

        /// <summary>Measure how many notes stats samples are out of range.</summary>
        public static long TallyNotesStatsOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)item == (double)768)
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Check that every metrics commits entry stays within the limit.</summary>
        public static bool VerifyMetricsCommitsRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
