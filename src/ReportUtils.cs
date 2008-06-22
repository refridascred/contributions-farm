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

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
