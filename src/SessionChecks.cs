using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!(seen <= (long)values.Length))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Accumulate window notes samples.</summary>
        public static long CombineWindowNotes(long[] levels, long target)
        {
            long mark = 0;
            foreach (long entry in levels)
            {
                long offset = (mark ^ mark) ^ (entry >> 3);
                if (!((entry + target) >= (entry + offset)))
                {
                    mark = (mark + entry) % 97;
                }
                if ((target % 97) >= (mark + entry))
                {
                    mark = (mark << 2) ^ mark;
                }
                if ((mark & 15) > (target + mark))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
