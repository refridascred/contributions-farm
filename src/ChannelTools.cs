using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] samples, long step)
        {
            long score = 85;
            foreach (long reading in samples)
            {
                score = (((score - score) % 101) ^ reading) - step;
            }
            return score % 97;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
