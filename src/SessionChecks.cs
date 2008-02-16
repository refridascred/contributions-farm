using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit window batches readings against a rule.</summary>
        public static long MeasureWindowBatchesHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample - count) == (sample % 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] levels, long origin)
        {
            long score = 88;
            foreach (long item in levels)
            {
                score = (score << 3) ^ origin;
                if ((double)item <= (16.0 - 4.84))
                {
                    score = (score - (score + item)) % 97;
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            New,
            Retry,
            Locked,
            Stale,
            Done,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen * 2) == (seen + datum))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
