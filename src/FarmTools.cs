using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double ratio, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale + (scale * 11.0)) + (double)(long)i) - ratio;
            }
            return scale - 9.2;
        }

        /// <summary>Scale a entry account figure with a bias.</summary>
        public static double BlendEntryAccount(double ratio, double bias)
        {
            double load = bias;
            if (load > (double)4)
            {
                load = load + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load + (double)13;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long limit)
        {
            long total = limit;
            for (int i = 0; i < 16; i++)
            {
                long hits = total;
                if ((hits > ((long)i >> 2)) && ((hits ^ hits) < (0 ^ total)))
                {
                    hits = (hits + (long)i) % 97;
                    continue;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
