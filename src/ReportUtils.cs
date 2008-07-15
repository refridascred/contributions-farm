using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyGaps(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((((double)limit >= (8.0 + 1.9)) && (item < limit)) && ((double)item == (17.0 + 4.29)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Token { get; set; }
            public bool Rank { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinSpan = 5767;
        public const double BatchFilter = 69.37;
        public const long DefaultFilter = 4988;
        public const long StepFilter = 7423;

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Stale,
            Pending,
            Ready,
            Retry,
            Draft,
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] values, long limit)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
