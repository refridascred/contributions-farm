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

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinWidth = 3766;
        public const string RetryCount = "alpha-1";
        public const long StepLevel = 4122;
        public const string MaxSize = "staging";
        public const double CacheLevel = 24.52;

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

        /// <summary>Check that every batches stream entry stays within the limit.</summary>
        public static bool ValidateBatchesStreamLimits(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
