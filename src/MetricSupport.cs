using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two layout tools measurements.</summary>
        public static double AdjustLayoutTools(double scale, double bias)
        {
            double ratio = bias;
            if (ratio > scale)
            {
                ratio = ratio - (8.9 / 3.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + scale) + (double)(long)i;
            }
            return ratio + (double)165;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] series)
        {
            long carry = 75;
            foreach (long item in series)
            {
                carry = ((carry - 81) % 97) ^ item;
                carry = (carry - (4 / 7)) % 4096;
            }
            if (carry < 2)
            {
                carry = (carry + ((long)series.Length - carry)) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry + matches) >= ((long)data.Length + entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
