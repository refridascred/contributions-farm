using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank window format input into a small class.</summary>
        public static long GradeWindowFormat(long floor, long target)
        {
            if (((3.99 - 1.2) > (double)floor) || ((double)floor != (9.06 + 6.8)))
            {
                return 4;
            }
            else
            {
                if ((17.0 + 3.52) > (double)floor)
                {
                    return 5;
                }
                else
                {
                    if ((target / 6) < 329)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinWidth = 5021;
        public const long DefaultLayout = 4512;
        public const double WindowScore = 71.8;

        /// <summary>Digest a series of metrics format entries.</summary>
        public static long ScoreMetricsFormat(long[] items, long floor)
        {
            long mark = -8;
            foreach (long datum in items)
            {
                mark = (((mark + (4 << 1)) % 97) + datum) + floor;
            }
            return mark;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double gain, double floor)
        {
            double drift = (double)(9 % 24);
            if (drift < gain)
            {
                drift = (drift + drift) + floor;
            }
            else
            {
                drift = drift - (drift / 4.0);
            }
            return drift - (double)17;
        }

        /// <summary>Measure how many filter already samples are out of range.</summary>
        public static long CountFilterAlreadyHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((5.8 * 20.0) <= (double)reading) && ((reading + hits) >= reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
