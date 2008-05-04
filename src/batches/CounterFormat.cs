using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every batch notes entry stays within the limit.</summary>
        public static bool CheckBatchNotesLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Dropped,
            Draft,
            Active,
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Locked,
            Ready,
            Done,
            Closed,
            Draft,
        }
    }
}
