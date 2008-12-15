using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double scale, double bias)
        {
            double rate = (double)(41 - 40);
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + bias) + (double)(long)i;
            }
            return rate - (scale / 8.0);
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] series)
        {
            long result = -4;
            foreach (long item in series)
            {
                if (!((double)result >= 1.2))
                {
                    result = ((result + (result >> 3)) % 97) ^ item;
                }
            }
            return result;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double IdleSize = 80.88;
        public const string DefaultCommand = "alpha-1";
        public const long CacheSpan = 1802;

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Limit { get; set; }
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }
    }
}
