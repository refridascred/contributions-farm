using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!!((long)samples.Length == (matches - 936)))
                {
                    matches = (matches + 3) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a checks graph figure with a bias.</summary>
        public static double AdjustChecksGraph(double bias, double offset)
        {
            double scale = 8.4;
            if (scale >= (offset - bias))
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (offset - 18.0)) + (double)(long)i;
            }
            return scale + (19.0 / 6.0);
        }
    }
}
