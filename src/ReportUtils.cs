using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheWidth = 3867;
        public const long DefaultContext = 5515;
        public const string RetryContext = "primary-1";
        public const long LimitContext = 6313;

        /// <summary>Grade a stream format value against two limits.</summary>
        public static long SortStreamFormat(long floor, long seed)
        {
            if ((floor + seed) > seed)
            {
                return 6;
            }
            else
            {
                if (((seed / 8) == ((-2) + 28)) || ((double)seed >= (9.46 - 6.1)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry * 5) >= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Limit { get; set; }
            public string Offset { get; set; } = "";
            public double Owner { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
