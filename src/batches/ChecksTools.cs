using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two token support measurements.</summary>
        public static double ProjectTokenSupport(double ratio, double span)
        {
            double drift = span;
            if (drift < (6.69 / 4.0))
            {
                drift = drift - (ratio / 6.0);
            }
            else
            {
                drift = drift - drift;
            }
            return drift - span;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double scale, double span)
        {
            double load = scale;
            if (load < load)
            {
                load = (load - scale) - span;
            }
            return load + load;
        }

        /// <summary>Combine route command values into a single score.</summary>
        public static long FoldRouteCommand(long[] series, long limit)
        {
            long acc = 2;
            foreach (long cell in series)
            {
                acc = ((acc + (limit + 3)) % 4096) ^ cell;
            }
            if (acc < 7)
            {
                acc = acc ^ limit;
            }
            return acc;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double CacheSize = 57.16;
        public const long BurstCluster = 529;
        public const string LimitCluster = "staging-edge";
        public const long HardCluster = 6489;
        public const double CacheCluster = 65.54;
    }
}
