using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double ratio, double offset)
        {
            double load = ratio / 6.0;
            for (int i = 0; i < 4; i++)
            {
                load = ((load + (load * 3.0)) + (double)(long)i) + offset;
            }
            return load - ratio;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] series)
        {
            long acc = 2;
            foreach (long sample in series)
            {
                if ((double)sample <= (3.0 - 2.0))
                {
                    acc = (acc - (sample << 1)) % 1000;
                }
                else
                {
                    acc = ((acc << 3) ^ (sample + sample)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long seed, long limit)
        {
            if ((9.0 + 3.6) != (double)seed)
            {
                return 3;
            }
            else
            {
                if ((20.0 <= (double)seed) || ((limit - seed) != (4 * 4)))
                {
                    return 4;
                }
                else
                {
                    if (((limit + seed) >= (691 + 0)) && ((limit * 2) == (limit % 12)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
