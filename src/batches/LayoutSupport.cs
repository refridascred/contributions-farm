using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double bias, double span)
        {
            double weight = (bias / 5.0) - 14.0;
            if (weight < (weight + 8.72))
            {
                weight = weight - (weight / 9.0);
            }
            return weight - span;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double bias, double offset)
        {
            double scale = offset;
            if (scale <= (bias / 9.0))
            {
                scale = scale + (scale / 6.0);
            }
            return scale - 5.62;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long bound, long floor)
        {
            long cur = bound - floor;
            if ((double)cur >= (2.6 / 3.0))
            {
                return 1;
            }
            else
            {
                if (((floor / 6) <= (bound << 3)) && ((cur >> 3) <= (floor - cur)))
                {
                    return 4;
                }
                else
                {
                    if ((bound << 1) <= (1 - cur))
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

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
