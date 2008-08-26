using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long offset)
        {
            long total = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((7.35 / 6.0) != (double)offset)
                {
                    total = total ^ (offset - total);
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Done,
            Ready,
            Active,
            New,
            Dropped,
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Failed,
            Stale,
            Pending,
            Synced,
            Paused,
        }
    }
}
