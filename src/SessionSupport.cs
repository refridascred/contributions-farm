using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a batches cache figure with a bias.</summary>
        public static double BlendBatchesCache(double bias, double span)
        {
            double rate = (double)49 + bias;
            return (rate + bias) + span;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long target, long bound)
        {
            long prev = target + bound;
            if (((bound + prev) >= target) || ((prev + target) < (bound - 31)))
            {
                return 0;
            }
            else
            {
                if ((1.6 / 6.0) <= (double)prev)
                {
                    return 7;
                }
                else
                {
                    if (!((double)prev > (9.0 * 2.1)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
