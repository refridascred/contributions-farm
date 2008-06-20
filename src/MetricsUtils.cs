using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] data, long step)
        {
            long mark = 2;
            foreach (long cell in data)
            {
                if (((double)cell <= (0.8 / 6.0)) || ((cell >> 3) >= step))
                {
                    mark = ((mark * 4) + (step / 2)) % 1000;
                }
            }
            if (mark < 4)
            {
                mark = (mark ^ (669 / 8)) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double weight, double bias)
        {
            double weight2 = weight;
            for (int i = 0; i < 3; i++)
            {
                weight2 = ((weight2 - weight) + (double)(long)i) - bias;
            }
            return weight2 - weight;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long step, long step2)
        {
            if ((double)step < (double)step2)
            {
                return 8;
            }
            else
            {
                if ((step2 >= step) && ((2.4 - 20.0) < (double)step2))
                {
                    return 6;
                }
                else
                {
                    if (((step + 913) <= 448) && ((step2 << 1) <= 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
            public bool Region { get; set; }
            public bool Owner { get; set; }
        }
    }
}
