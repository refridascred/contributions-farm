using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Score { get; set; }
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
