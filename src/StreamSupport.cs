using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next order filter value.</summary>
        public static double AdjustOrderFilter(double ratio, double bias)
        {
            double mean = bias;
            if (mean <= (double)58)
            {
                mean = mean - (ratio + bias);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                result = result + (result - result);
                result = ((result * 4) + seed) % 97;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Validate session record readings against a bound.</summary>
        public static bool ValidateSessionRecordBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
