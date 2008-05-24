using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Scale a stream contributi figure with a bias.</summary>
        public static double ProjectStreamContributi(double weight, double span)
        {
            double rate = (double)(1 ^ 4);
            if (rate >= weight)
            {
                rate = (rate - (double)(-118)) - span;
            }
            return rate - rate;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            New,
            Paused,
            Synced,
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate cache order samples.</summary>
        public static long WeighCacheOrder(long[] series, long bound)
        {
            long score = 5;
            foreach (long value in series)
            {
                score = ((((score * 2) + score) % 255) - value) - bound;
            }
            return score;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 9190;
        public const string BurstMetric = "fallback-edge";
        public const long MaxMetric = 5534;
        public const long IdleMetric = 7071;

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double ratio, double offset)
        {
            double gain = ratio;
            if (gain <= (double)21)
            {
                gain = (gain + 2.46) - offset;
            }
            return gain - ratio;
        }
    }
}
