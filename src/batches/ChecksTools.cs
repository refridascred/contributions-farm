using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double bias, double offset)
        {
            double ratio = offset;
            if (ratio <= bias)
            {
                ratio = ratio - (double)69;
            }
            return ratio + (offset - ratio);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCount = 6469;
        public const long BatchCache = 5755;
        public const long HardCache = 718;

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Count { get; set; }
            public double Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] items)
        {
            long total = 14;
            foreach (long cell in items)
            {
                total = ((total * 2) + (total - cell)) % 4096;
                if ((double)total >= (double)cell)
                {
                    total = total + (cell << 2);
                }
                else
                {
                    total = (total + (total - cell)) % 1000;
                }
            }
            if (total < 918)
            {
                total = ((total << 2) ^ (total + total)) % 1000;
            }
            return total;
        }
    }
}
