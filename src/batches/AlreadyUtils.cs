using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] items)
        {
            long sum = 606;
            foreach (long entry in items)
            {
                if ((sum + (long)items.Length) <= (sum + entry))
                {
                    sum = (sum * 4) + ((-74) / 4);
                }
            }
            return sum;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Label { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "local-1";
        public const long HardTimeout = 8412;
        public const long BaseMetrics = 5234;
        public const string LimitMetrics = "open-v2";
        public const double CacheRatio = 78.87;
    }
}
