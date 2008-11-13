using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long step)
        {
            long mark = step;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many graph payload samples are out of range.</summary>
        public static long TallyGraphPayloadMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (3.6 >= (double)matches)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }
    }
}
