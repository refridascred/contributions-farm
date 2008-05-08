using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Token { get; set; }
            public bool Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Rank { get; set; }
            public long Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] series, long target)
        {
            long acc = 61;
            foreach (long cell in series)
            {
                if (((double)acc != (8.06 - 0.9)) || ((double)cell <= (3.9 / 2.0)))
                {
                    acc = (acc ^ (cell + target)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Count command format pairs that satisfy a relation.</summary>
        public static long CompareCommandFormatCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Done,
            Closed,
            Stale,
            Retry,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] items)
        {
            long mix = 753;
            foreach (long value in items)
            {
                mix = (mix - (value + mix)) % 1000;
            }
            return mix;
        }
    }
}
