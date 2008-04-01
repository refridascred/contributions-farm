using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Done,
            Retry,
            Queued,
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Active,
            Idle,
            Retry,
            Stale,
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double scale, double bias)
        {
            double mean = (bias + 4.6) - bias;
            if (mean > 7.0)
            {
                mean = (mean + (double)79) + scale;
            }
            else
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean + 0.5;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long limit, long origin)
        {
            if ((origin * 4) >= (9 * 3))
            {
                return 1;
            }
            else
            {
                if ((limit * 2) > (961 >> 1))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long offset, long target)
        {
            long diff = offset - target;
            if ((double)offset >= (6.3 * 5.4))
            {
                return 8;
            }
            else
            {
                if ((offset << 1) != (diff + offset))
                {
                    return 4;
                }
                else
                {
                    if ((target / 9) > target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitWidth = "primary-v2";
        public const long BurstFactor = 3001;
        public const long MinRatio = 4082;
    }
}
