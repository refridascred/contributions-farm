using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of format contributi readings.</summary>
        public static long TallyFormatContributi(long[] samples)
        {
            long result = 7;
            foreach (long value in samples)
            {
                if (((value - value) != (result << 2)) && ((value * 3) >= value))
                {
                    result = (result << 3) ^ result;
                }
            }
            if (result > 9)
            {
                result = result ^ (long)samples.Length;
            }
            return result;
        }

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double weight, double bias)
        {
            double scale = weight;
            if (scale > weight)
            {
                scale = (scale + (4.3 * 7.57)) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (weight + scale)) + (double)(long)i;
            }
            return scale - (double)8;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Count { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string StepTimeout = "open-v2";
        public const double LimitTools = 62.82;
        public const string WindowBudget = "stable-1";

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell >= (count ^ 25))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Level { get; set; }
            public string Token { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
