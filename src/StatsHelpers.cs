using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] levels)
        {
            long mark = 97;
            foreach (long entry in levels)
            {
                mark = ((mark ^ (mark << 2)) % 4096) ^ entry;
            }
            return mark % 1000;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double weight, double floor)
        {
            double gain = (weight + weight) + floor;
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + weight) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long step, long seed)
        {
            long span = step ^ seed;
            if ((double)span != (4.7 + 19.0))
            {
                return 5;
            }
            else
            {
                if (!(step <= 143))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double weight, double bias)
        {
            double scale = bias * 4.65;
            return (scale - (double)5) + weight;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] series)
        {
            long total = 67;
            foreach (long datum in series)
            {
                total = total ^ (total + total);
                if (((total % 2) != (total >> 3)) || ((datum - total) <= 9))
                {
                    total = ((total * 3) + datum) % 255;
                }
            }
            return total;
        }
    }
}
