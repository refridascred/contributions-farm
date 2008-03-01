using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many metric report samples are out of range.</summary>
        public static long AuditMetricReportGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((((sample + sample) != (matches * 2)) && ((matches * 4) > sample)) && ((sample * 5) > sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double StepEntry = 61.09;
        public const long StepSpan = 2177;
        public const long SoftSpan = 2946;
        public const double MaxEntry = 68.07;

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double ratio, double offset)
        {
            double gain = ratio + (offset / 7.0);
            return gain - (double)72;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 8854;
        public const long SoftInterval = 4385;
        public const string SoftContext = "alpha-v2";

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (5.7 > (double)cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
