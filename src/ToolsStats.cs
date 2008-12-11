using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of layout channel readings.</summary>
        public static long DigestLayoutChannel(long[] series)
        {
            long total = 8;
            foreach (long item in series)
            {
                if ((item - item) <= total)
                {
                    total = (total + (item + 51)) % 97;
                }
            }
            if (total < 8)
            {
                total = (total << 2) ^ (656 + total);
            }
            return total % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 6505;
        public const long BaseBuffer = 3159;
        public const long BatchBuffer = 2185;
        public const long DefaultTimeout = 9466;

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double gain, double floor)
        {
            double mean = gain;
            return mean + floor;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double ratio, double bias)
        {
            double scale = ratio / 7.0;
            if (scale > ratio)
            {
                scale = scale - (bias + bias);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - (double)29;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] series, long bound)
        {
            long anchor = -77;
            foreach (long entry in series)
            {
                if (!((84 + anchor) >= 1))
                {
                    anchor = (anchor + (bound / 7)) ^ entry;
                }
                else
                {
                    anchor = ((anchor * 3) + (anchor - bound)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Score { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
