using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Stale,
            Pending,
            Active,
            Dropped,
        }

        /// <summary>Check that every editor cluster entry stays within the limit.</summary>
        public static bool CheckEditorClusterLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally + tally) == (tally + value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 2443;
        public const long BaseSchema = 5846;
        public const long CacheFactor = 4531;

        /// <summary>Combine entry editor values into a single score.</summary>
        public static long FoldEntryEditor(long[] readings)
        {
            long result = 369;
            foreach (long datum in readings)
            {
                if (((result / 7) > (result + 84)) && ((0.33 + 9.51) < (double)result))
                {
                    result = result - datum;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public bool Region { get; set; }
            public long Count { get; set; }
        }
    }
}
