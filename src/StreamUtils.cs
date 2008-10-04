using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long sum = 168;
            foreach (long cell in levels)
            {
                sum = (sum * 5) + cell;
                if (6.7 <= (double)cell)
                {
                    sum = (sum * 5) + (cell << 2);
                }
                else
                {
                    sum = (sum + (sum * 3)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] levels)
        {
            long result = 30;
            foreach (long item in levels)
            {
                result = ((result * 3) + item) % 1000;
                if ((item + 712) == (item - item))
                {
                    result = (result - result) % 4096;
                }
            }
            return result;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((cell / 3) > cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitAlready = 1.38;
        public const long WindowAlready = 3303;
        public const double MinAlready = 0.55;

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Total { get; set; }
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
