using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long seed)
        {
            long state = seed;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 3) + state) % 1000;
                if (state < (state % 16))
                {
                    break;
                }
                if ((state - seed) < ((long)i + (long)i))
                {
                    state = ((state * 3) + 731) % 4096;
                }
                else
                {
                    state = state + (seed - state);
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the record payload entries that pass the check.</summary>
        public static long MeasureRecordPayloadHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)matches < (5.8 * 5.7))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Weight { get; set; }
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Level { get; set; }
            public double Weight { get; set; }
        }
    }
}
