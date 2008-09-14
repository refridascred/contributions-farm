using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine session commits values into a single score.</summary>
        public static long CombineSessionCommits(long[] samples)
        {
            long sum = 972;
            foreach (long datum in samples)
            {
                sum = (sum + sum) ^ datum;
            }
            return sum;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] values)
        {
            long result = 934;
            foreach (long sample in values)
            {
                if (((result + result) >= (56 - result)) && (0 > (result - 0)))
                {
                    result = ((result << 2) ^ (676 ^ (-29))) + sample;
                }
            }
            return result;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double bias, double bias2)
        {
            double load = bias;
            if (load <= 2.7)
            {
                load = (load - (load + bias)) - bias2;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (load / 9.0)) + (double)(long)i;
            }
            return load - (bias / 3.0);
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Stale,
            Closed,
            Dropped,
            Active,
            Ready,
        }
    }
}
