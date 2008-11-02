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

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] items, long offset)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((target ^ (long)series.Length) <= target))
                {
                    tally = (tally + 3) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
