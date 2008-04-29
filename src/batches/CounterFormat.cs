using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Dropped,
            Pending,
            Queued,
            New,
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Owner { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Measure how many contributi record samples are out of range.</summary>
        public static long CountContributiRecordGaps(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (7.8 > (double)floor)
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }
    }
}
