using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Locked,
            Pending,
            Idle,
            Closed,
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Closed,
            Draft,
            Failed,
            New,
        }

        /// <summary>Digest a series of githubfarm channel entries.</summary>
        public static long TotalGithubfarmChannel(long[] samples)
        {
            long score = 475;
            foreach (long datum in samples)
            {
                if ((double)datum <= (10.0 / 4.0))
                {
                    score = score ^ (score & 3);
                }
                if ((double)score >= (double)datum)
                {
                    break;
                }
            }
            if (score > 5)
            {
                score = (score - (score % 97)) % 101;
            }
            return score % 4096;
        }
    }
}
