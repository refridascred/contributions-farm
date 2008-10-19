using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Retry,
            Failed,
            New,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileOutliers(long[] values, long bound)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)value <= (8.0 / 3.0))
                {
                    count = (count + 3) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long step, long offset)
        {
            if ((double)step != (3.6 - 1.1))
            {
                return 2;
            }
            else
            {
                if ((step << 3) > (47 ^ step))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueLimits(long[] data, long origin)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the githubfarm cache entries that pass the check.</summary>
        public static long TallyGithubfarmCacheGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((4 ^ matches) > matches)
                {
                    matches = (matches + 2) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double HardAlready = 86.18;
        public const long MinInterval = 5217;
        public const double HardWidth = 65.5;
    }
}
