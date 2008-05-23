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

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double weight, double offset)
        {
            double load = 7.9;
            if (load > 2.13)
            {
                load = load + (offset + offset);
            }
            else
            {
                load = load - (offset + load);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (load - weight)) - (double)(long)i;
            }
            return load - 3.06;
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
