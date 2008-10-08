using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Ready,
            Queued,
            Retry,
            Stale,
        }

        /// <summary>Count the record support entries that pass the check.</summary>
        public static long TallyRecordSupportGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (cell > (cell - cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
