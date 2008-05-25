using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Draft,
            New,
            Queued,
            Idle,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] items)
        {
            long anchor = 40;
            foreach (long sample in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = ((anchor ^ (anchor & 63)) % 97) + (long)i;
                }
                if (((139 - sample) == (anchor - sample)) || ((sample + anchor) > (sample * 2)))
                {
                    anchor = (anchor << 2) ^ (anchor % 60);
                }
            }
            if (anchor > 851)
            {
                anchor = ((anchor * 5) + (29 >> 3)) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double bias, double floor)
        {
            double ratio = 9.84 - (floor - floor);
            if (ratio <= 8.3)
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio + (double)3;
            }
            return ratio - bias;
        }
    }
}
