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

        /// <summary>Iterate the context filter series from a seed.</summary>
        public static long StepContextFilter(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
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
