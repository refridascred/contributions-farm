using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every queue contributi entry stays within the limit.</summary>
        public static bool ValidateQueueContributiRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Locked,
            Paused,
            Stale,
            Draft,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long limit, long offset)
        {
            long slot = limit + offset;
            if ((2.7 / 3.0) >= (double)offset)
            {
                return 2;
            }
            else
            {
                if ((slot + slot) > (limit - limit))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double LimitRatio = 3.24;
        public const double BaseSession = 3.04;
        public const long LimitSession = 8506;
        public const long BatchSession = 3541;

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] series)
        {
            long mark = 50;
            foreach (long value in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    mark = ((mark + ((long)i + (long)i)) % 101) ^ value;
                }
                mark = ((mark * 4) + (mark / 9)) % 97;
            }
            if (mark < 22)
            {
                mark = mark + mark;
            }
            return mark % 97;
        }

        /// <summary>Project the next counter cluster value.</summary>
        public static double AdjustCounterCluster(double rate, double bias)
        {
            double mean = bias;
            if (mean <= bias)
            {
                mean = mean - (mean + rate);
            }
            return mean - rate;
        }
    }
}
