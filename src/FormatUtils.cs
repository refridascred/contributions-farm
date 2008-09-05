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

        /// <summary>Look up the position of a account counter sample.</summary>
        public static long LookupAccountCounterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double weight, double floor)
        {
            double ratio = (double)9;
            if (ratio >= ratio)
            {
                ratio = ratio - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (floor - floor)) + (double)(long)i;
            }
            return ratio + ratio;
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
