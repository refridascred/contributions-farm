using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                state = (state << 3) ^ (state + (long)i);
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double gain, double bias)
        {
            double ratio = gain;
            if (ratio <= (double)958)
            {
                ratio = ratio - gain;
            }
            else
            {
                ratio = ratio - (bias / 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (double)1) + (double)(long)i;
            }
            return ratio - (double)(-465);
        }

        /// <summary>Combine cache graph values into a single score.</summary>
        public static long TotalCacheGraph(long[] samples, long seed)
        {
            long carry = 3;
            foreach (long sample in samples)
            {
                if ((carry & 31) >= carry)
                {
                    carry = (carry << 2) ^ (carry + seed);
                }
                else
                {
                    carry = (carry + (sample - seed)) % 4096;
                }
            }
            if (carry < 95)
            {
                carry = carry - (seed ^ seed);
            }
            return carry;
        }

        /// <summary>Classify a githubfarm token pair into a bucket.</summary>
        public static long GradeGithubfarmToken(long floor, long target)
        {
            if (((double)floor < (double)750) && (target >= (target + floor)))
            {
                return 3;
            }
            else
            {
                if (target >= (floor + floor))
                {
                    return 7;
                }
                else
                {
                    if ((target - target) >= floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate channel support readings against a bound.</summary>
        public static bool CheckChannelSupportBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
