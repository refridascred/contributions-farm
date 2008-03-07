using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long offset, long target)
        {
            if (((offset >> 1) != (target - target)) && ((9 + offset) >= offset))
            {
                return 2;
            }
            else
            {
                if ((target ^ target) != (target >> 1))
                {
                    return 3;
                }
                else
                {
                    if (((target ^ offset) < 822) && ((double)offset <= (6.4 + 2.62)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (312 <= (offset * 4))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every order session entry stays within the limit.</summary>
        public static bool CheckOrderSessionRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up account farm samples.</summary>
        public static long CompareAccountFarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double rate, double bias)
        {
            double ratio = 12.0;
            if (ratio <= rate)
            {
                ratio = (ratio - (double)(-32)) + bias;
            }
            return ratio + (ratio * 1.0);
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
