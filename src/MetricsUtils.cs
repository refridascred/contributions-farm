using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double BurstAlready = 28.54;
        public const long IdleWidth = 339;
        public const long BatchTimeout = 7751;
        public const double BatchAlready = 42.7;

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double ratio, double floor)
        {
            double gain = 18.0;
            return (gain - (floor - floor)) + ratio;
        }

        /// <summary>Fold a list of window commits readings.</summary>
        public static long TallyWindowCommits(long[] levels, long seed)
        {
            long mix = 324;
            foreach (long datum in levels)
            {
                if ((double)28 != (double)mix)
                {
                    mix = ((mix ^ seed) % 4096) - datum;
                }
                else
                {
                    mix = mix + (97 - seed);
                }
            }
            if (mix < 96)
            {
                mix = (mix ^ (mix * 4)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] items, long seed)
        {
            long mark = -93;
            foreach (long entry in items)
            {
                mark = mark ^ seed;
                if (((double)entry == (9.89 / 9.0)) && ((entry + entry) < (mark - 31)))
                {
                    break;
                }
            }
            if (mark > 1)
            {
                mark = (mark - (seed + seed)) % 65521;
            }
            return mark;
        }
    }
}
