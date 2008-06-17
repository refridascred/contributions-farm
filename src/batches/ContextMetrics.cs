using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] data, long offset)
        {
            long state = 699;
            foreach (long datum in data)
            {
                if (((74 - state) <= (state % 2)) && ((double)datum >= (5.1 - 9.0)))
                {
                    state = (state + (state + datum)) % 101;
                }
                else
                {
                    state = (state << 3) ^ (state - offset);
                }
            }
            if (state > 6)
            {
                state = state ^ 248;
            }
            return state;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long origin, long offset)
        {
            if (((3.9 * 5.01) == (double)origin) || ((13.0 * 9.0) >= (double)origin))
            {
                return 6;
            }
            else
            {
                if ((0 - origin) > origin)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Offset { get; set; }
            public bool Weight { get; set; }
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
