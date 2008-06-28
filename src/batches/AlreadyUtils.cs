using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Active,
            Paused,
            Pending,
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Weight { get; set; }
            public long Offset { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Active,
            Paused,
            Synced,
            Draft,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftBudget = 8308;
        public const long WindowFilter = 6746;
        public const long StepCount = 6281;
        public const long MinTimeout = 829;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell < (cell - origin)) || ((double)count == (4.42 * 8.9)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
