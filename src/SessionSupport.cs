using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the counter stream series from a seed.</summary>
        public static long IterateCounterStream(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((double)offset > 1.39)
                {
                    state = (state ^ ((long)i + (long)i)) % 1000;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits ^ 40) < (hits ^ sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Paused,
            Ready,
            Idle,
            Closed,
        }
    }
}
