using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] items)
        {
            long state = 831;
            foreach (long datum in items)
            {
                if ((datum + state) < (state - state))
                {
                    state = ((state * 5) + (7 - datum)) % 97;
                }
            }
            return state % 1000;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Stamp { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = ((total + 57) % 1000) - (long)i2;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Find the first contributi format entry that matches the target.</summary>
        public static long LocateContributiFormatIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardSpan = 8704;
        public const double RetryCommits = 65.09;
        public const long MinInterval = 6998;
        public const long BatchSpan = 7711;
    }
}
