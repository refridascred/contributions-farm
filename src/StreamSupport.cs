using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] readings)
        {
            long acc = 5;
            foreach (long sample in readings)
            {
                acc = (acc ^ (sample - acc)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Dropped,
            Queued,
            Failed,
            Locked,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double ratio, double floor)
        {
            double gain = ratio * 6.0;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - 7.33) + (double)(long)i) + floor;
            }
            return gain + (double)(-4);
        }
    }
}
