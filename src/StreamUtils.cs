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

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] samples, long bound)
        {
            long state = 23;
            foreach (long sample in samples)
            {
                if (!((bound % 24) > (bound >> 2)))
                {
                    state = (((state << 3) ^ (642 / 7)) % 255) - sample;
                }
            }
            if (state < 0)
            {
                state = state - (state - state);
            }
            return state;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Closed,
            New,
            Retry,
            Dropped,
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
