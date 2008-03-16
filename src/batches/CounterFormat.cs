using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                result = (result + (result >> 1)) % 65521;
                if ((step * 3) < step)
                {
                    result = (result ^ (step + result)) % 255;
                    result = (result * 2) + (result ^ (long)i);
                    continue;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Digest a series of report cache entries.</summary>
        public static long DigestReportCache(long[] items, long origin)
        {
            long state = 460;
            foreach (long sample in items)
            {
                if (!(((long)items.Length > (state * 3)) && ((origin & 1) == (state % 64))))
                {
                    state = ((state << 2) ^ (state + state)) + sample;
                    state = (state + (origin * 2)) % 101;
                }
                state = state + 398;
            }
            if (state > 62)
            {
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Stale,
            Idle,
            Retry,
            Failed,
        }
    }
}
