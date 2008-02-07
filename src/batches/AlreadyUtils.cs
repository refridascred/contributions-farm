using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long step, long target)
        {
            if ((8.9 + 6.0) != (double)step)
            {
                return 3;
            }
            else
            {
                if ((((-9) - step) == (target + step)) && (step > (5 % 2)))
                {
                    return 8;
                }
                else
                {
                    if (step > (step & 7))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(step >= (target & 1)))
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

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchScore = 1441;
        public const string DefaultSpan = "stable-edge";
        public const long BatchDepth = 1512;
        public const double SoftScore = 26.81;

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] values, long offset)
        {
            long total = -45;
            foreach (long value in values)
            {
                if ((value ^ 33) == (286 ^ 246))
                {
                    total = ((total << 3) ^ (total + 350)) % 4096;
                }
                if (offset <= value)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double bias, double span)
        {
            double mean = bias + span;
            if (mean > (span / 9.0))
            {
                mean = mean - (span * 3.05);
            }
            else
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (span - 0.1)) - (double)(long)i;
            }
            return mean + (bias - span);
        }
    }
}
