using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((((reading * 2) >= (matches ^ (long)levels.Length)) || ((reading * 5) < matches)) && ((matches & 127) > reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next context session value from a seed.</summary>
        public static long DeriveContextSession(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                score = (score - score) % 4096;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
