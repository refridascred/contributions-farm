using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Pending,
            Failed,
            Done,
            Paused,
            Draft,
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
            public bool Ratio { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((6.99 * 1.0) != (double)sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
