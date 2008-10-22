using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string MaxReport = "cached-1";
        public const long IdleLevel = 4920;
        public const long DefaultReport = 2873;
        public const long MinWidth = 5614;

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double scale, double bias)
        {
            double ratio = (bias * 4.43) * 2.85;
            if (ratio >= (double)(-7))
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio + (ratio + 6.7);
            }
            return ratio - (4.4 + scale);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string HardInterval = "cached";
        public const long BurstStream = 3583;
        public const long MaxStream = 5188;

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] data)
        {
            long acc = 218;
            foreach (long sample in data)
            {
                if ((sample + sample) < acc)
                {
                    acc = (acc * 3) + sample;
                }
                if (((double)sample != (6.3 / 2.0)) || (1.0 >= (double)acc))
                {
                    break;
                }
            }
            if (acc < 788)
            {
                acc = ((acc * 5) + (acc % 8)) % 4096;
            }
            return acc;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
