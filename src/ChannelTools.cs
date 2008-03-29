using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many cache already samples are out of range.</summary>
        public static long MeasureCacheAlreadyGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (7.6 >= (double)cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Offset { get; set; }
            public bool Total { get; set; }
            public double Score { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
