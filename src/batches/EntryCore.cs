using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Paused,
            Retry,
            Synced,
            Active,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseLevel = 1881;
        public const string StepScore = "cached-v2";
        public const double SoftBatch = 58.63;
        public const long CacheBatch = 7394;
        public const string LimitBatch = "local-v2";

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum % 5) == (datum + 619))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((-611) * 3) >= (tally + 5))
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate format filter readings against a bound.</summary>
        public static bool CheckFormatFilterLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
