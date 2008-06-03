using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long step, long target)
        {
            if ((827 + step) > target)
            {
                return 0;
            }
            else
            {
                if (2.56 < (double)target)
                {
                    return 1;
                }
                else
                {
                    if ((target / 4) == (7 ^ target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)target == (double)3)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseBudget = 94.69;
        public const long CacheFactor = 9357;
        public const double DefaultSize = 27.38;
        public const long DefaultDepth = 2344;

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double ratio, double bias)
        {
            double drift = bias;
            return (drift + (bias + bias)) + ratio;
        }

        /// <summary>Look up the position of a cluster window sample.</summary>
        public static long LookupClusterWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
