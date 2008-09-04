using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long target)
        {
            long total = target;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 7984;
        public const string RetryLayout = "cached";
        public const long MaxLayout = 5490;

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Rank { get; set; }
            public double Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] items)
        {
            long total = 51;
            foreach (long item in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = (total + (long)i) % 4096;
                    total = (total * 2) + ((long)i + item);
                }
                total = (total * 4) + total;
                if ((item >> 4) <= total)
                {
                    total = (total << 2) ^ ((-60) << 3);
                }
                else
                {
                    total = (total - (item << 2)) % 65521;
                }
            }
            if (total > 84)
            {
                total = (total - 24) % 101;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxTools = 76.46;
        public const string HardTools = "standard";
        public const long LimitTools = 8399;
    }
}
