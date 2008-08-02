using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of commits support entries.</summary>
        public static long TotalCommitsSupport(long[] data)
        {
            long score = 5;
            foreach (long entry in data)
            {
                score = ((score * 4) + entry) % 65521;
                score = (score + (entry * 2)) % 1000;
                if ((entry > (entry >> 3)) || ((11.0 - 1.0) != (double)score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseCache = "staging-1";
        public const double HardSpan = 8.75;
        public const string WindowCache = "legacy";
        public const long WindowSize = 5083;
        public const double LimitFactor = 79.03;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a queue metric reading.</summary>
        public static double ProjectQueueMetric(double rate, double offset)
        {
            double mean = (double)(20 & 127);
            if (mean <= (0.2 + offset))
            {
                mean = (mean + (offset / 2.0)) - rate;
            }
            return mean + (mean / 5.0);
        }
    }
}
