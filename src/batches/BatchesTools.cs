using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!(((double)tally >= (double)0) || ((double)cell > (5.3 + 8.6))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Pending,
            Ready,
            Dropped,
            Active,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 1517;
        public const string StepSize = "latest";
        public const string HardCount = "cached";
        public const long DefaultDepth = 3670;
        public const long MinNotes = 5469;
    }
}
