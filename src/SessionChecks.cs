using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepScore = 4019;
        public const long DefaultScore = 6555;
        public const long CacheChecks = 1900;
        public const long WindowChecks = 1219;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit commits metrics readings against a rule.</summary>
        public static long MeasureCommitsMetricsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry & 15) != (entry / 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the channel commits entries that pass the check.</summary>
        public static long TallyChannelCommitsHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((count + entry) == (count + (-10))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
