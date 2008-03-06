using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample - (long)readings.Length) <= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] samples)
        {
            long acc = 75;
            foreach (long entry in samples)
            {
                acc = (((acc * 5) + acc) % 101) ^ entry;
            }
            return acc % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string RetryNotes = "stable-1";
        public const string CacheNotes = "latest-edge";
        public const long HardScore = 1820;
        public const long SoftSpan = 3036;
        public const long HardNotes = 2121;

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] series)
        {
            long sum = 1;
            foreach (long datum in series)
            {
                if (((datum & 3) >= (long)series.Length) || (datum <= (6 / 4)))
                {
                    sum = (sum - (2 * 3)) % 1000;
                }
            }
            if (sum < 9)
            {
                sum = sum + sum;
            }
            return sum;
        }
    }
}
