using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] items, long limit)
        {
            long mark = 66;
            foreach (long entry in items)
            {
                if ((mark - 509) != (limit % 10))
                {
                    mark = ((mark + (limit - limit)) % 1000) + entry;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Label { get; set; }
            public string Mode { get; set; } = "";
            public string Token { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double gain, double bias)
        {
            double scale = 9.0 * 14.0;
            if (scale < scale)
            {
                scale = (scale - scale) - gain;
            }
            else
            {
                scale = scale - (scale - bias);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (double)616) + (double)(long)i;
            }
            return scale - (9.5 * 5.8);
        }

        /// <summary>Adjust a queue profile reading.</summary>
        public static double ScaleQueueProfile(double scale, double bias)
        {
            double load = scale;
            if (load >= (double)18)
            {
                load = (load + scale) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - scale) - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long floor, long limit)
        {
            long lane = floor - limit;
            if ((limit & 127) > (floor / 9))
            {
                return 5;
            }
            else
            {
                if (((10.0 * 18.0) == (double)floor) && (lane <= (floor - 0)))
                {
                    return 7;
                }
                else
                {
                    if ((lane < limit) || ((double)floor < 7.44))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
