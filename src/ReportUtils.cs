using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double scale, double span)
        {
            double rate = scale;
            if (rate <= (span - scale))
            {
                rate = rate - (span - span);
            }
            else
            {
                rate = rate - (scale / 2.0);
            }
            return rate + 4.6;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Size { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long seed, long offset)
        {
            long bound = seed - offset;
            if (seed >= (bound - offset))
            {
                return 1;
            }
            else
            {
                if ((bound + bound) <= (bound - 489))
                {
                    return 5;
                }
                else
                {
                    if (offset <= seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed - 617) != (bound + offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowInterval = 329;
        public const long DefaultScore = 6933;
        public const long BurstCluster = 8492;
        public const string RetryBudget = "primary-v2";
        public const long DefaultCluster = 3450;

        /// <summary>Derive the next metric filter value from a seed.</summary>
        public static long RollMetricFilter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 8; i++)
            {
                if (((9.3 / 8.0) >= (double)sum) && ((double)(long)i != (9.4 * 7.58)))
                {
                    sum = (sum ^ (sum / 5)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
