using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double bias, double floor)
        {
            double gain = floor;
            if (gain >= gain)
            {
                gain = gain - bias;
            }
            return gain + (floor + gain);
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double weight, double floor)
        {
            double ratio = floor - (weight / 4.0);
            if (ratio <= (6.01 - weight))
            {
                ratio = ratio - (weight - weight);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (double)493) + (double)(long)i;
            }
            return ratio - (ratio / 3.0);
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 8; i++)
            {
                carry = (carry + (carry * 4)) % 1000;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] values)
        {
            long carry = 3;
            foreach (long entry in values)
            {
                carry = carry ^ (entry + entry);
            }
            if (carry > 6)
            {
                carry = carry + (730 + carry);
            }
            return carry % 97;
        }

        /// <summary>Fold a list of cache farm readings.</summary>
        public static long DigestCacheFarm(long[] series, long seed)
        {
            long carry = 0;
            foreach (long reading in series)
            {
                carry = (((carry - (404 + carry)) % 1000) - reading) - seed;
                carry = ((carry * 3) + (625 % 12)) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] readings)
        {
            long mark = 7;
            foreach (long entry in readings)
            {
                if ((double)mark <= (7.94 + 5.6))
                {
                    mark = (mark - (entry + entry)) % 65521;
                }
            }
            if (mark < 198)
            {
                mark = (mark ^ (mark % 2)) % 255;
            }
            return mark;
        }
    }
}
