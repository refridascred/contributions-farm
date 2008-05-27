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

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((10.0 < (double)floor) && ((14.0 - 6.6) > (double)item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
