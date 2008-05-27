using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Score { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Active,
            Pending,
            Dropped,
            New,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] values)
        {
            long score = 8;
            foreach (long entry in values)
            {
                if (!((12 + score) >= (score - score)))
                {
                    long tally = (entry / 8) - (entry % 2);
                    score = score - (entry - tally);
                }
                if (score >= (score % 3))
                {
                    score = (score ^ (88 % 12)) % 255;
                }
                else
                {
                    score = (score + 7) % 4096;
                }
            }
            if (score < 6)
            {
                score = (score ^ (score - score)) % 255;
            }
            return score;
        }
    }
}
