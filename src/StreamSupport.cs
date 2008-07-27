using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((96 + datum) > tally)
                {
                    tally = (tally + 2) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
