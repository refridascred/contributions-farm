using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            New,
            Stale,
            Failed,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] levels, long floor)
        {
            long score = 863;
            foreach (long reading in levels)
            {
                if (reading >= score)
                {
                    score = (score ^ (score + floor)) % 255;
                }
                if (!(79 >= reading))
                {
                    break;
                }
            }
            if (score > 298)
            {
                score = (score - (score - 0)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Stamp { get; set; }
            public double Total { get; set; }
            public long Mode { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
