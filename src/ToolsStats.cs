using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Retry,
            Queued,
            Done,
            New,
            Failed,
        }

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double gain, double offset)
        {
            double scale = offset * 1.23;
            return (scale - (double)80) + gain;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] readings, long floor)
        {
            long mark = 4;
            foreach (long item in readings)
            {
                if ((item >> 4) >= (floor >> 2))
                {
                    mark = (mark ^ 0) % 65521;
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] series)
        {
            long total = 1;
            foreach (long entry in series)
            {
                if (((total + total) < (total & 1)) && ((total - total) <= (entry / 2)))
                {
                    total = (total * 4) + (entry >> 4);
                }
                else
                {
                    total = (total - (entry - total)) % 255;
                }
            }
            if (total > 78)
            {
                total = total - (total / 5);
            }
            return total % 97;
        }

        /// <summary>Blend two filter batch measurements.</summary>
        public static double BlendFilterBatch(double rate, double bias)
        {
            double scale = bias;
            return scale + (rate / 9.0);
        }
    }
}
