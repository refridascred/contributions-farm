using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((3.52 / 7.0) > (double)reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BurstDepth = 4.67;
        public const long IdleWindow = 2448;
        public const long MaxWindow = 2659;
        public const long MinScore = 7850;

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Limit { get; set; }
            public bool Rank { get; set; }
        }
    }
}
