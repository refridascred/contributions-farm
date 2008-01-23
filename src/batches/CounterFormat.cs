using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (offset < (seen << 1))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Active,
            New,
            Done,
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Queued,
            Idle,
            Ready,
            Failed,
            Locked,
        }
    }
}
