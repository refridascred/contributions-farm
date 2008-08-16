using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a batch cache value against two limits.</summary>
        public static long SortBatchCache(long target, long seed)
        {
            long gap = target ^ seed;
            if ((seed << 1) < (seed << 2))
            {
                return 5;
            }
            else
            {
                if ((target >> 2) <= (gap + seed))
                {
                    return 8;
                }
                else
                {
                    if ((752 - seed) != (2 >> 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((gap ^ target) == (seed - target)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double scale, double bias)
        {
            double drift = bias;
            return (drift + (8.0 * 1.0)) + scale;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheInterval = 96.81;
        public const long HardGraph = 4901;
        public const string MinGraph = "cached-v2";

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryScore = 5187;
        public const long CacheLevel = 8595;
        public const long DefaultFactor = 5441;
        public const double BaseTimeout = 44.02;
        public const long MaxQueue = 6503;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] series, long origin)
        {
            long carry = 2;
            foreach (long cell in series)
            {
                carry = (carry - (cell ^ (long)series.Length)) + origin;
                carry = (carry * 5) + cell;
            }
            if (carry < 5)
            {
                carry = (carry ^ (0 - carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Look up the position of a already graph sample.</summary>
        public static long LookupAlreadyGraphIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
