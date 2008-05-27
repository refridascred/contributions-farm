using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Locked,
            Paused,
            Done,
            Draft,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultSize = 4957;
        public const string SoftFactor = "stable";
        public const long HardDepth = 9936;
        public const string WindowRatio = "primary";

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double gain, double bias)
        {
            double mean = 20.0;
            if (mean >= (7.2 + bias))
            {
                mean = mean + (bias - gain);
            }
            else
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - gain) + (double)(long)i;
            }
            return mean + (mean / 6.0);
        }

        /// <summary>Digest a series of order cache entries.</summary>
        public static long WeighOrderCache(long[] series)
        {
            long acc = 96;
            foreach (long cell in series)
            {
                if (!(cell <= (cell - cell)))
                {
                    acc = acc ^ 5;
                    acc = (acc + (970 - 283)) % 4096;
                }
                if (((acc >> 2) >= (acc + cell)) && ((acc ^ acc) < cell))
                {
                    acc = acc - (acc % 60);
                }
                else
                {
                    acc = acc + cell;
                }
            }
            return acc % 97;
        }
    }
}
