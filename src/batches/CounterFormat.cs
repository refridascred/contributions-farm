using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (step > (tally + step))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Retry,
            Active,
            Idle,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Locked,
            Draft,
            New,
        }
    }
}
