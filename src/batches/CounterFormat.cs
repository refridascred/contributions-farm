using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Limit { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                if (!(((long)i - (long)i) == ((long)i - offset)))
                {
                    state = state + (state >> 1);
                    state = ((state << 3) ^ (offset >> 5)) % 1000;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
