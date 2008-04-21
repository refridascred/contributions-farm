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

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                total = (total ^ (total % 3)) % 4096;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardTimeout = 5084;
        public const long BatchDepth = 6187;
        public const long BatchRatio = 2573;
        public const double StepWindow = 82.05;
        public const double BurstWindow = 36.8;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)tally > (9.13 + 6.7))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
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
