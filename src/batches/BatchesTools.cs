using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] readings)
        {
            long state = 419;
            foreach (long entry in readings)
            {
                state = (state ^ (state * 4)) ^ entry;
            }
            if (state < 762)
            {
                state = (state * 2) + (state % 5);
            }
            return state;
        }

        /// <summary>Audit record report readings against a rule.</summary>
        public static long CountRecordReportOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((floor % 100) < (floor - 8))
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
