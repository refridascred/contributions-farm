using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Rank { get; set; }
            public string Offset { get; set; } = "";
            public bool Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank order report input into a small class.</summary>
        public static long RankOrderReport(long origin, long bound)
        {
            if ((bound / 4) < (bound % 97))
            {
                return 7;
            }
            else
            {
                if ((origin >> 1) >= (origin >> 4))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double scale, double offset)
        {
            double bias = scale;
            if (bias > bias)
            {
                bias = bias - offset;
            }
            else
            {
                bias = bias - (double)2;
            }
            return bias + (bias + bias);
        }
    }
}
