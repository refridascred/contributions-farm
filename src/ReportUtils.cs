using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a commits graph counter forward.</summary>
        public static long DeriveCommitsGraph(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((origin << 3) > (mark ^ mark))
                {
                    mark = mark ^ (mark >> 4);
                }
                else
                {
                    mark = (mark + ((long)i / 4)) % 1000;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mark = ((mark + (origin * 3)) % 97) - (long)i2;
                }
                if ((origin + origin) <= (-797))
                {
                    mark = mark ^ origin;
                }
                else
                {
                    mark = mark ^ origin;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value + value) < (0 * 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double rate, double floor)
        {
            double weight = 5.5;
            if (weight > 1.97)
            {
                weight = (weight + (rate * 4.2)) - floor;
            }
            return weight + (0.64 + weight);
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double ratio, double bias)
        {
            double rate = (bias - bias) + (double)588;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + (rate - rate)) + (double)(long)i) + ratio;
            }
            return rate + rate;
        }
    }
}
