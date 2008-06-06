using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Region { get; set; }
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
