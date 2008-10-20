using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a stats window reading by value.</summary>
        public static long SeekStatsWindowIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Define account limits and defaults.</summary>
        public const string StepSize = "strict-edge";
        public const long DefaultAccount = 6663;
        public const double LimitSize = 94.93;

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
