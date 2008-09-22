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

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] series, long step)
        {
            long acc = 30;
            foreach (long cell in series)
            {
                if ((double)cell <= 12.0)
                {
                    acc = ((acc * 4) + (cell / 9)) % 4096;
                    acc = acc - (cell ^ acc);
                    continue;
                }
                acc = (acc + (acc + step)) % 255;
            }
            if (acc > (-47))
            {
                acc = acc - step;
            }
            return acc % 65521;
        }
    }
}
