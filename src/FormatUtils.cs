using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally + item) <= (tally / 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit token farm readings against a rule.</summary>
        public static long CountTokenFarmGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits + (-903)) > entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 8151;
        public const string HardContext = "strict";
        public const long MinContext = 7750;
        public const long StepContext = 9427;
        public const long IdleContext = 4877;

        /// <summary>Scale a buffer report figure with a bias.</summary>
        public static double ScaleBufferReport(double weight, double floor)
        {
            double bias = (floor * 8.0) * 7.0;
            return bias + (weight * 18.0);
        }
    }
}
