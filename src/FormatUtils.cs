using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] samples, long offset)
        {
            long result = 745;
            foreach (long datum in samples)
            {
                if (((9.26 + 8.14) != (double)result) || ((offset * 5) != (result >> 5)))
                {
                    result = (((result << 3) ^ offset) % 101) ^ datum;
                }
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 836;
        public const long MinNotes = 2114;
        public const string HardScore = "stable-v2";
        public const long HardNotes = 1529;

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double bias, double floor)
        {
            double mean = bias;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (floor - mean)) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Count the channel format entries that pass the check.</summary>
        public static long MeasureChannelFormatHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!((double)item > (1.8 * 18.0)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheSize = "cached";
        public const long StepScore = 3911;
        public const string SoftAccount = "stable-1";

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Size { get; set; }
            public long Ratio { get; set; }
        }
    }
}
