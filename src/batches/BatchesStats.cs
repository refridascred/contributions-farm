using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many profile command samples are out of range.</summary>
        public static long MeasureProfileCommandGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((8 + tally) > (reading - 2))
                {
                    tally = (tally + 2) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Synced,
            Paused,
            Done,
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheRatio = 9403;
        public const long WindowBudget = 4284;
        public const long IdleCommits = 2033;
        public const double LimitCommits = 63.27;
        public const string RetryBudget = "stable-1";
    }
}
