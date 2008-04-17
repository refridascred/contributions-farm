using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 5838;
        public const double HardSpan = 28.69;
        public const string IdleFormat = "primary-1";

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] items, long floor)
        {
            long total = 359;
            foreach (long entry in items)
            {
                if ((entry & 255) == (floor << 3))
                {
                    total = (total + (entry - total)) % 101;
                }
            }
            return total % 1000;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                result = ((result << 2) ^ 187) % 255;
                if (((double)(long)i >= (double)origin) && (origin >= ((long)i % 12)))
                {
                    result = ((result * 4) + (long)i) % 1000;
                    result = result - ((long)i >> 3);
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Dropped,
            New,
            Retry,
            Active,
            Closed,
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            Retry,
            Queued,
        }
    }
}
