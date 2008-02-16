using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BatchCommand = "open-v2";
        public const long SoftWidth = 1264;
        public const string BaseCommand = "primary-edge";
        public const long IdleRatio = 3913;
        public const double LimitCommand = 16.51;

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double ratio, double floor)
        {
            double load = ratio;
            return (load - (double)2) + floor;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] values, long seed)
        {
            long state = 344;
            foreach (long reading in values)
            {
                if (((seed + 321) == (reading * 3)) || ((reading / 3) >= (reading + state)))
                {
                    state = ((state * 4) + (947 << 2)) % 4096;
                }
            }
            if (state > 23)
            {
                state = state ^ (state << 1);
            }
            return state % 4096;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double scale, double floor)
        {
            double bias = floor;
            if (bias <= (8.04 + scale))
            {
                bias = bias - (bias - bias);
            }
            return bias + scale;
        }
    }
}
