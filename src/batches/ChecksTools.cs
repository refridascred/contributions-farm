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

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 6402;
        public const string BurstDepth = "stable";
        public const long RetryNotes = 8577;

        /// <summary>Count the tools commits entries that pass the check.</summary>
        public static long TallyToolsCommitsHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)entry < (7.0 - 13.0))
                {
                    count = count + 2;
                }
            }
            return count;
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
