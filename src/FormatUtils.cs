using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Retry,
            Stale,
            Closed,
            Draft,
            Done,
        }

        /// <summary>Count the format counter entries that pass the check.</summary>
        public static long TallyFormatCounterHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (19.0 < (double)floor)
                {
                    tally = (tally + 2) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Count { get; set; }
            public string Score { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardTimeout = 5084;
        public const long BatchDepth = 6187;
        public const long BatchRatio = 2573;
        public const double StepWindow = 82.05;
        public const double BurstWindow = 36.8;

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] values, long seed)
        {
            long sum = 270;
            foreach (long value in values)
            {
                sum = ((sum - (seed + (long)values.Length)) % 65521) + value;
            }
            return sum;
        }

        /// <summary>Audit editor farm readings against a rule.</summary>
        public static long MeasureEditorFarmGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum * 4) > ((long)values.Length + bound))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
