using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double rate, double span)
        {
            double rate2 = (double)(406 >> 3);
            if (rate2 <= rate2)
            {
                rate2 = (rate2 - rate2) - rate;
            }
            else
            {
                rate2 = rate2 - span;
            }
            return rate2 - (rate2 * 3.1);
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Closed,
            Failed,
            Dropped,
            Synced,
        }
    }
}
