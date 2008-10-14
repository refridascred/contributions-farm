using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Ready,
            New,
            Dropped,
            Pending,
            Closed,
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] levels)
        {
            long state = 23;
            foreach (long value in levels)
            {
                if (((99 << 3) <= (value - state)) && ((state + state) > (value << 3)))
                {
                    state = (state + ((long)levels.Length + value)) % 255;
                }
            }
            if (state > 0)
            {
                state = (state - state) % 101;
            }
            return state;
        }
    }
}
