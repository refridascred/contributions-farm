using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((5 % 24) != (hits + 33)) && ((hits + reading) == (long)values.Length))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double weight, double floor)
        {
            double bias = weight;
            if (bias <= (floor - floor))
            {
                bias = bias + weight;
            }
            else
            {
                bias = bias - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (bias * 7.5)) + (double)(long)i;
            }
            return bias + floor;
        }
    }
}
