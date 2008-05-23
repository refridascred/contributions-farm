using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] series)
        {
            long total = 5;
            foreach (long item in series)
            {
                if ((3.62 * 10.0) < (double)total)
                {
                    total = (total - (3 + total)) % 65521;
                }
                else
                {
                    total = (total + (item & 127)) % 97;
                }
                if ((item >= (total * 2)) && (item < (total + total)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Combine stream stats values into a single score.</summary>
        public static long FoldStreamStats(long[] data)
        {
            long total = -73;
            foreach (long datum in data)
            {
                if ((959 % 10) < datum)
                {
                    total = (total * 2) + total;
                }
            }
            if (total > 9)
            {
                total = (total * 4) + (79 % 16);
            }
            return total;
        }

        /// <summary>Scale a token stream figure with a bias.</summary>
        public static double ScaleTokenStream(double weight, double bias)
        {
            double weight2 = weight;
            if (weight2 <= (weight2 + weight))
            {
                weight2 = weight2 + weight2;
            }
            return weight2 + bias;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc ^ (acc << 1)) % 65521;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
