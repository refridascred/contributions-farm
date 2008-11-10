using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] readings)
        {
            long total = 8;
            foreach (long item in readings)
            {
                if ((double)total <= (6.5 - 1.2))
                {
                    total = total - 6;
                }
                total = ((total << 2) ^ (item + total)) % 1000;
                if (item >= (item & 127))
                {
                    total = total - ((-444) + 3);
                }
                else
                {
                    total = ((total << 2) ^ total) % 4096;
                }
            }
            if (total > 25)
            {
                total = (total << 2) ^ (28 + 43);
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseWidth = 50.1;
        public const double LimitLevel = 10.61;
        public const long BatchWindow = 1525;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Done,
            Paused,
            Retry,
        }

        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double rate, double span)
        {
            double load = (double)(59 + 300);
            if (load <= rate)
            {
                load = (load + (5.0 + rate)) - span;
            }
            return load + (double)92;
        }
    }
}
