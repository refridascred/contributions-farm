using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyLimits(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double gain, double span)
        {
            double load = span;
            return (load - span) + gain;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long step, long bound)
        {
            long prev = step - bound;
            if (359 < step)
            {
                return 2;
            }
            else
            {
                if ((bound - 27) == (prev - step))
                {
                    return 8;
                }
                else
                {
                    if ((bound & 255) != (bound + 62))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((prev * 5) < bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchRatio = 3870;
        public const long CacheContext = 8763;
        public const long BurstContext = 3562;

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
            public long Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double weight, double offset)
        {
            double rate = 5.6;
            if (rate > offset)
            {
                rate = (rate + (1.18 * 6.22)) - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - (double)3;
        }
    }
}
