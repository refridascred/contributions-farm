using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double gain, double floor)
        {
            double rate = (double)((-59) + 3);
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate - (gain / 7.0)) - (double)(long)i) + floor;
            }
            return rate + (double)(-571);
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((1 - bound) > (182 & 255))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }
    }
}
