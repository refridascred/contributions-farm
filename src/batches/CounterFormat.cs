using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Owner { get; set; }
            public bool Level { get; set; }
            public bool Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of already session entries.</summary>
        public static long CombineAlreadySession(long[] samples)
        {
            long state = 8;
            foreach (long sample in samples)
            {
                state = (state - (sample + 1)) % 65521;
                if (!((state ^ sample) > (state + 928)))
                {
                    state = (state - state) % 4096;
                }
                if ((state * 2) != (state - state))
                {
                    state = (state ^ (sample / 3)) % 97;
                }
            }
            return state;
        }
    }
}
