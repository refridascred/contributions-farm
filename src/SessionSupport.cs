using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a batches channel reading.</summary>
        public static double AdjustBatchesChannel(double weight, double offset)
        {
            double bias = (weight / 8.0) * 0.28;
            if (bias > offset)
            {
                bias = bias - 0.8;
            }
            else
            {
                bias = bias - (bias + offset);
            }
            return bias - (double)6;
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
