using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Count { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (item > (matches & 31))
                {
                    matches = (matches + 3) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] samples, long origin)
        {
            long score = 35;
            foreach (long datum in samples)
            {
                score = (((score * 2) + (score * 5)) ^ datum) - origin;
            }
            return score % 65521;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Active,
            Dropped,
            Idle,
            Locked,
        }
    }
}
