using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheCount = "legacy";
        public const string HardBuffer = "staging";
        public const string SoftDepth = "local";

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleSize = 197;
        public const long SoftBudget = 9087;
        public const long RetryScore = 4451;
        public const long HardDepth = 7237;

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Count { get; set; }
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((((tally % 60) < 611) && ((cell >> 2) > (cell - cell))) || ((double)bound < (8.0 / 7.0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
