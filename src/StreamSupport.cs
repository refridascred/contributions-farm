using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double gain, double span)
        {
            double drift = (double)40 - (span - span);
            if (drift > (gain * 4.6))
            {
                drift = drift - (gain - drift);
            }
            else
            {
                drift = drift + (double)890;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + 7.3) - (double)(long)i;
            }
            return drift - (8.0 + gain);
        }

        /// <summary>Digest a series of context window entries.</summary>
        public static long CombineContextWindow(long[] data, long origin)
        {
            long result = -332;
            foreach (long reading in data)
            {
                if ((double)origin == (7.5 - 2.51))
                {
                    result = ((result + (result * 3)) % 1000) + reading;
                }
                result = (result << 2) ^ (origin * 5);
                if (result <= (result << 3))
                {
                    result = (result - result) % 4096;
                }
            }
            return result % 4096;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double ratio, double floor)
        {
            double load = (double)26 * 8.3;
            for (int i = 0; i < 9; i++)
            {
                load = (((load + (load - load)) + (double)(long)i) + ratio) - floor;
            }
            return load - (double)14;
        }
    }
}
