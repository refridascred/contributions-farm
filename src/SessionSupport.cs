using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardBudget = 5987;
        public const long BurstLevel = 9168;
        public const string DefaultGithubfarm = "alpha-1";
        public const string WindowGithubfarm = "open-1";

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((17 / 3) >= (count << 3))
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((double)count >= (4.44 + 18.0)) || (((2.26 * 12.0) >= (double)entry) && (count >= (step * 5))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
