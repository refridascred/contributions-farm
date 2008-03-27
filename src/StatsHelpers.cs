using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string HardRatio = "primary-edge";
        public const long DefaultInterval = 4643;
        public const long LimitLayout = 8965;

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] series)
        {
            long total = 9;
            foreach (long value in series)
            {
                total = (total << 2) ^ (value << 1);
                if (((long)series.Length & 15) >= value)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((98 + bound) == (bound << 2))
                {
                    sum = sum ^ ((long)i ^ (long)i);
                    break;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Scale a window entry figure with a bias.</summary>
        public static double SmoothWindowEntry(double weight, double bias)
        {
            double scale = bias;
            if (scale <= (double)1)
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (weight - bias)) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double rate, double bias)
        {
            double weight = (double)(654 >> 3);
            if (weight >= (double)(-7))
            {
                weight = ((weight + (double)9) + rate) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + 3.2;
        }
    }
}
