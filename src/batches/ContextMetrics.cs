using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!(cell <= (count - cell)))
                {
                    count = (count + 1) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long floor, long seed)
        {
            long lane = floor ^ seed;
            if (floor >= (985 >> 5))
            {
                return 8;
            }
            else
            {
                if ((1.77 + 4.0) > (double)seed)
                {
                    return 5;
                }
                else
                {
                    if (!((double)lane < (6.96 - 6.9)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((496 - floor) <= 6)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double gain, double bias)
        {
            double drift = gain;
            if (drift < (double)0)
            {
                drift = (drift + gain) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + gain) + (double)(long)i;
            }
            return drift + 1.4;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((492 + target) > (hits >> 5))
                {
                    hits = (hits + 3) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
