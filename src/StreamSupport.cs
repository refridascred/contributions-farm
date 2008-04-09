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

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] levels)
        {
            long acc = 1;
            foreach (long reading in levels)
            {
                if ((3.0 * 2.81) >= (double)acc)
                {
                    acc = (acc ^ (reading + reading)) % 97;
                }
            }
            if (acc < 776)
            {
                acc = (acc ^ (acc + 26)) % 255;
            }
            return acc;
        }
    }
}
