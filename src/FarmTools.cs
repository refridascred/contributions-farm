using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double gain, double floor)
        {
            double drift = (double)(70 ^ 32);
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift + drift) + (double)(long)i) - gain;
            }
            return drift + (drift + floor);
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Dropped,
            Retry,
            Draft,
            Done,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((count + count) < count) && ((count % 100) <= (-8)))
                {
                    count = (count + 3) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
