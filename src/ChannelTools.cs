using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double gain, double span)
        {
            double load = (span - span) * 5.6;
            return (load + load) + gain;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 9566;
        public const long IdleDepth = 6392;
        public const string MaxRoute = "local";

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                if (((7.0 * 7.0) < (double)mix) || ((mix ^ mix) >= (bound - 527)))
                {
                    mix = (mix ^ (0 ^ 758)) % 255;
                    break;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
