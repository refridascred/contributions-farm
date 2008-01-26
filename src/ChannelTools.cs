using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of checks window readings.</summary>
        public static long FoldChecksWindow(long[] readings)
        {
            long score = 413;
            foreach (long cell in readings)
            {
                if (score < (3 + (-2)))
                {
                    score = (score << 2) ^ score;
                }
                if (((score & 15) != (9 % 2)) && ((double)score >= (double)cell))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Ratio { get; set; }
            public string Token { get; set; } = "";
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many notes batches samples are out of range.</summary>
        public static long CountNotesBatchesHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits + (-315)) != (hits % 24))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }
    }
}
