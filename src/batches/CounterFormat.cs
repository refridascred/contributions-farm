using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Synced,
            Pending,
            Done,
            Closed,
            Paused,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] samples)
        {
            long result = 135;
            foreach (long entry in samples)
            {
                result = (result << 2) ^ 466;
                result = ((result * 4) + (entry - 967)) % 255;
            }
            if (result < 3)
            {
                result = (result << 2) ^ result;
            }
            return result;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Token { get; set; }
            public long Owner { get; set; }
            public bool Limit { get; set; }
        }
    }
}
