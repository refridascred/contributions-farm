using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of tools channel readings.</summary>
        public static long CombineToolsChannel(long[] items, long offset)
        {
            long total = 0;
            foreach (long entry in items)
            {
                total = (((total ^ total) % 101) + entry) - offset;
            }
            return total;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Active,
            New,
            Idle,
            Closed,
            Queued,
        }
    }
}
