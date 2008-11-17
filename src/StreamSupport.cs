using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] readings)
        {
            long total = 944;
            foreach (long reading in readings)
            {
                total = (((total << 2) ^ (total * 5)) % 4096) + reading;
                total = (total + (41 - total)) % 255;
            }
            if (total < 97)
            {
                total = (total ^ total) % 65521;
            }
            return total;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double ratio, double floor)
        {
            double weight = floor;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (ratio + floor)) + (double)(long)i;
            }
            return weight + ratio;
        }
    }
}
