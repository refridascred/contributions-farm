using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] readings, long step)
        {
            long result = 73;
            foreach (long value in readings)
            {
                result = (((result * 5) + (step & 7)) % 65521) - value;
                result = result - (step - (-15));
            }
            return result % 1000;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Retry,
            Draft,
            New,
            Stale,
            Pending,
        }
    }
}
