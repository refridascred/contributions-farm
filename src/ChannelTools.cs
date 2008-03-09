using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next filter queue value.</summary>
        public static double SmoothFilterQueue(double bias, double span)
        {
            double load = (span - span) / 3.0;
            if (load <= (double)427)
            {
                load = (load + load) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = load - (double)(long)i;
            }
            return load + (double)1;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                result = ((result << 2) ^ (result & 63)) % 255;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Accumulate buffer filter samples.</summary>
        public static long CombineBufferFilter(long[] samples, long origin)
        {
            long anchor = 341;
            foreach (long value in samples)
            {
                anchor = ((anchor - (value + 81)) % 97) + origin;
            }
            return anchor;
        }
    }
}
