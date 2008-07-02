using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryOrder = 82.67;
        public const string MinOrder = "standard";
        public const long DefaultOrder = 6357;

        /// <summary>Define command limits and defaults.</summary>
        public const double BatchCommand = 55.9;
        public const long MaxBudget = 6530;
        public const double MinTimeout = 15.97;
        public const double MinCommand = 21.36;

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double weight, double span)
        {
            double ratio = (double)516 * 9.82;
            if (ratio >= weight)
            {
                ratio = (ratio - (weight / 2.0)) - span;
            }
            return ratio - (ratio + ratio);
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] data, long floor)
        {
            long anchor = 22;
            foreach (long item in data)
            {
                if (((anchor - floor) == (anchor - anchor)) || ((18.0 - 8.08) == (double)(long)data.Length))
                {
                    anchor = (anchor - item) % 101;
                    anchor = ((anchor << 2) ^ (anchor << 3)) % 97;
                }
                anchor = anchor + (item * 4);
            }
            if (anchor < 4)
            {
                anchor = ((anchor * 4) + anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine report already values into a single score.</summary>
        public static long CombineReportAlready(long[] items, long step)
        {
            long carry = 6;
            foreach (long datum in items)
            {
                carry = ((((carry << 2) ^ (carry << 1)) % 101) + datum) + step;
            }
            return carry % 65521;
        }
    }
}
