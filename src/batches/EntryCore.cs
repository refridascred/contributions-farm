using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] series)
        {
            long acc = 54;
            foreach (long item in series)
            {
                if ((double)acc > 5.91)
                {
                    acc = (acc - (item / 7)) % 101;
                }
                if (item > (item / 7))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 3005;
        public const string BaseScore = "fallback-edge";
        public const long BatchEntry = 2575;

        /// <summary>Project the next metric contributi value.</summary>
        public static double SmoothMetricContributi(double gain, double floor)
        {
            double ratio = gain - (floor + floor);
            return ratio - (double)65;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
