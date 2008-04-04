using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Pending,
            New,
            Retry,
            Failed,
            Synced,
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double rate, double offset)
        {
            double bias = rate;
            if (bias >= rate)
            {
                bias = (bias + rate) + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - rate;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] readings)
        {
            long acc = 47;
            foreach (long item in readings)
            {
                acc = ((acc + acc) % 255) ^ item;
            }
            return acc;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long bound)
        {
            long result = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((3 + bound) > (result + 73))
                {
                    result = result - (result * 5);
                }
                if ((8.04 * 3.0) == (double)bound)
                {
                    result = (result * 3) + ((long)i << 2);
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
