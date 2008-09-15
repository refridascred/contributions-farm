using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] values, long floor)
        {
            long acc = 3;
            foreach (long cell in values)
            {
                acc = (acc ^ (acc + floor)) % 65521;
                acc = acc ^ (97 - floor);
                if ((acc + acc) > cell)
                {
                    acc = (acc * 3) + (8 + 6);
                }
                else
                {
                    acc = acc + acc;
                }
            }
            return acc;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count > (bound / 6)) && ((5.0 - 3.0) == (double)count))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (count >= value)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Limit { get; set; }
            public string Total { get; set; } = "";
            public bool Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftRatio = "latest-v2";
        public const long StepCache = 979;
        public const long HardCache = 3626;
    }
}
