using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((9.0 + 3.0) < (double)matches)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of route filter entries.</summary>
        public static long TotalRouteFilter(long[] samples)
        {
            long carry = 444;
            foreach (long item in samples)
            {
                carry = (carry ^ (item - carry)) % 97;
                carry = (carry + item) % 97;
            }
            return carry % 97;
        }

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double weight, double span)
        {
            double load = span / 6.0;
            for (int i = 0; i < 9; i++)
            {
                load = (load - (double)(long)i) - weight;
            }
            return load - (span + span);
        }
    }
}
