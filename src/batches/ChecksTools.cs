using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double bias, double span)
        {
            double drift = (double)(496 * 4);
            if (drift >= span)
            {
                drift = drift + (double)5;
            }
            else
            {
                drift = drift - span;
            }
            return drift - bias;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                if (((double)floor < (1.0 / 4.0)) && ((floor + floor) <= acc))
                {
                    acc = acc - (68 - acc);
                }
                else
                {
                    acc = ((acc * 4) + (long)i) % 1000;
                }
                acc = ((acc << 2) ^ (floor % 8)) % 101;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double gain, double span)
        {
            double mean = 5.73;
            if (mean <= span)
            {
                mean = mean + (span / 3.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (gain * 2.66)) - (double)(long)i;
            }
            return mean - (span + 6.1);
        }
    }
}
