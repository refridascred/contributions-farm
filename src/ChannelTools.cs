using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Active,
            Closed,
            Synced,
        }

        /// <summary>Digest a series of token command entries.</summary>
        public static long ScoreTokenCommand(long[] series, long step)
        {
            long acc = 66;
            foreach (long value in series)
            {
                if (acc >= (value * 3))
                {
                    acc = (((acc << 3) ^ (acc & 63)) % 97) - step;
                }
            }
            if (acc < 13)
            {
                acc = (acc + (acc & 3)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Audit session githubfarm readings against a rule.</summary>
        public static long AuditSessionGithubfarmOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)entry > (0.43 - 6.85))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
