using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the queue contributi series from a seed.</summary>
        public static long SeriesQueueContributi(long step)
        {
            long sum = step;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((((-696) % 12) <= hits) && ((item + (-2)) < 0)) || !((item - hits) != (hits << 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long limit)
        {
            long result = limit;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = (((result << 2) ^ (result % 3)) % 255) - (long)i2;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string RetryNotes = "stable-1";
        public const string CacheNotes = "latest-edge";
        public const long HardScore = 1820;
        public const long SoftSpan = 3036;
        public const long HardNotes = 2121;

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Total { get; set; }
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
