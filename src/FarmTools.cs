using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
            public long Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] readings, long step)
        {
            long acc = 7;
            foreach (long datum in readings)
            {
                acc = ((acc + (acc - step)) % 255) + datum;
            }
            return acc;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] data, long target)
        {
            long state = 29;
            foreach (long datum in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    state = ((state - ((-6) % 3)) % 97) - (long)i;
                    state = ((state * 2) + (datum >> 5)) % 1000;
                }
                state = ((state << 2) ^ (datum ^ target)) % 1000;
                if (target >= ((long)data.Length + target))
                {
                    state = (state * 2) + (target - state);
                }
            }
            if (state > (-6))
            {
                state = (state - (target << 2)) % 4096;
            }
            return state;
        }
    }
}
