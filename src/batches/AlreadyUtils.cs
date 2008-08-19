using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the entry stats series from a seed.</summary>
        public static long SeriesEntryStats(long offset)
        {
            long total = offset;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] values)
        {
            long mix = 4;
            foreach (long item in values)
            {
                mix = mix ^ item;
                mix = ((mix * 4) + (item + item)) % 255;
            }
            return mix;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 7591;
        public const long HardFormat = 2300;
        public const string HardBudget = "local";

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
