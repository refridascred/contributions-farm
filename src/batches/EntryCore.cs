using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] series)
        {
            long carry = 902;
            foreach (long sample in series)
            {
                carry = ((carry * 5) + (sample & 1)) % 255;
            }
            return carry;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((6.0 - 7.8) > (double)count)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!((reading + count) <= reading) || ((double)count > (2.9 * 19.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Blend two account filter measurements.</summary>
        public static double SmoothAccountFilter(double rate, double floor)
        {
            double weight = rate;
            if (weight <= (floor + rate))
            {
                weight = weight + 3.0;
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (9.59 / 5.0)) + (double)(long)i;
            }
            return weight - (weight * 8.4);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BurstReport = "legacy-v2";
        public const string HardReport = "fallback-edge";
        public const long MaxReport = 7401;
        public const long IdleRatio = 727;
        public const long BatchCount = 4390;
    }
}
