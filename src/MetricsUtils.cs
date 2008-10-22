using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a profile commits pair into a bucket.</summary>
        public static long RankProfileCommits(long limit, long origin)
        {
            long lane = limit ^ origin;
            if ((lane ^ limit) >= origin)
            {
                return 0;
            }
            else
            {
                if (limit > ((-831) - 4))
                {
                    return 7;
                }
                else
                {
                    if ((origin - limit) < (8 >> 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin & 7) < origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

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
