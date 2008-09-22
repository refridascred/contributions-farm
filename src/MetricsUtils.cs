using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseLevel = 8833;
        public const long StepChannel = 641;
        public const long MinChannel = 7141;

        /// <summary>Count the report batches entries that pass the check.</summary>
        public static long MeasureReportBatchesMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((13 % 8) > ((-5) + matches))
                {
                    matches = ((matches + 1) - cell) + step;
                }
            }
            return matches;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
