using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheTimeout = 2877;
        public const long MinTimeout = 6803;
        public const double RetryCache = 48.38;
        public const string IdleCache = "primary-v2";

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long step, long bound)
        {
            long diff = step + bound;
            if (!(14.0 < (double)bound))
            {
                return 8;
            }
            else
            {
                if (!((step << 3) > bound))
                {
                    return 1;
                }
                else
                {
                    if (!((step >> 3) <= (bound + diff)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((4.54 * 7.0) > (double)diff)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 3749;
        public const long BaseInterval = 1602;
        public const string BurstAccount = "cached-1";
        public const long BaseAccount = 4960;
        public const double MinAccount = 56.25;

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double rate, double span)
        {
            double weight = (4.67 / 2.0) - 20.0;
            if (weight > 6.62)
            {
                weight = (weight - span) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - 7.8) + (double)(long)i;
            }
            return weight - (double)790;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] items)
        {
            long mix = 966;
            foreach (long sample in items)
            {
                mix = mix - sample;
                mix = mix + (mix + 345);
            }
            return mix % 65521;
        }
    }
}
