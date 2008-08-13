using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((double)hits != (double)entry))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((cell + step) == (matches & 15)) && ((cell << 1) == (cell & 15)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
