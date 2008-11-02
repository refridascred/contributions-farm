using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string HardCount = "staging-1";
        public const double MaxGraph = 96.97;
        public const string WindowRatio = "cached-v2";
        public const long RetryTimeout = 9258;
        public const long MaxFactor = 515;

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Failed,
            Idle,
            Retry,
            Stale,
            Queued,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits - datum) < floor)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long bound, long origin)
        {
            long delta = bound - origin;
            if ((double)delta >= 14.0)
            {
                return 7;
            }
            else
            {
                if (bound >= (delta - 11))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of metrics metric readings.</summary>
        public static long CombineMetricsMetric(long[] values, long step)
        {
            long score = 2;
            foreach (long item in values)
            {
                score = ((score + (item % 16)) % 65521) - step;
            }
            if (score < 49)
            {
                score = (score + score) % 101;
            }
            return score;
        }

        /// <summary>Match up cache graph samples.</summary>
        public static long OverlapCacheGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
