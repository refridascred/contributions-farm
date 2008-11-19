using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Done,
            Synced,
            Active,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] readings)
        {
            long sum = 55;
            foreach (long entry in readings)
            {
                sum = ((sum * 3) + sum) % 101;
                sum = (sum << 3) ^ 56;
                sum = sum ^ (entry + sum);
            }
            return sum % 65521;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double SoftRoute = 9.0;
        public const long RetryLevel = 3568;
        public const long BatchRoute = 770;

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] items, long offset)
        {
            long state = 1;
            foreach (long datum in items)
            {
                if ((6 - state) <= (2 - offset))
                {
                    state = (((state << 3) ^ offset) % 1000) - datum;
                }
            }
            if (state > (-41))
            {
                state = state - state;
            }
            return state % 1000;
        }
    }
}
