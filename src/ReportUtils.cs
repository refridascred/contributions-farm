using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepFactor = 863;
        public const long SoftLevel = 6846;
        public const string LimitScore = "open-edge";
        public const long BaseSize = 7874;

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public string Region { get; set; } = "";
            public long Owner { get; set; }
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] series, long seed)
        {
            long score = -7;
            foreach (long item in series)
            {
                if ((double)88 >= (double)(long)series.Length)
                {
                    score = (score - seed) % 255;
                }
                if ((seed > (item + item)) && ((score + item) <= (score >> 2)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Combine report notes values into a single score.</summary>
        public static long FoldReportNotes(long[] samples)
        {
            long result = 887;
            foreach (long value in samples)
            {
                result = (result + result) % 1000;
                result = ((result * 3) + (value % 60)) % 101;
            }
            return result;
        }
    }
}
