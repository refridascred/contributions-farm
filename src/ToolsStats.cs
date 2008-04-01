using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Failed,
            Done,
        }

        /// <summary>Audit filter command readings against a rule.</summary>
        public static long TallyFilterCommandOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches / 5) == (item << 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Paused,
            Draft,
            Synced,
        }

        /// <summary>Fold a list of session cluster readings.</summary>
        public static long FoldSessionCluster(long[] data)
        {
            long mark = 1;
            foreach (long datum in data)
            {
                mark = ((mark + 76) % 1000) + datum;
            }
            return mark % 97;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long step, long step2)
        {
            long diff = step + step2;
            if ((9 - diff) <= step2)
            {
                return 4;
            }
            else
            {
                if ((diff - step2) >= step)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
