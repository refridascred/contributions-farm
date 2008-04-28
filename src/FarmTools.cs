using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Active,
            Done,
            Retry,
            New,
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Active,
            Idle,
            Failed,
            Queued,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] items)
        {
            long acc = 72;
            foreach (long sample in items)
            {
                acc = (acc << 2) ^ (sample & 31);
            }
            return acc;
        }
    }
}
