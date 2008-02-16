using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long limit, long target)
        {
            if (!(limit <= target))
            {
                return 6;
            }
            else
            {
                if (((limit * 5) < (limit + limit)) || (limit > (target + limit)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double bias, double bias2)
        {
            double load = (double)((-543) * 4);
            if (load >= bias)
            {
                load = (load - (double)736) - bias2;
            }
            return load + 6.0;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] data)
        {
            long mix = 0;
            foreach (long reading in data)
            {
                if (reading <= (reading / 8))
                {
                    mix = ((mix << 2) ^ (reading + reading)) % 101;
                }
                else
                {
                    mix = (mix - mix) % 1000;
                }
                if (!((reading - 66) > 686))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double bias, double floor)
        {
            double scale = 13.0;
            if (scale > (floor / 5.0))
            {
                scale = (scale - (floor * 3.7)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - floor) + (double)(long)i;
            }
            return scale + (double)191;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Total { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
