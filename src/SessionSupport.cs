using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Stamp { get; set; }
            public double Offset { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Iterate the checks githubfarm series from a seed.</summary>
        public static long RollChecksGithubfarm(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Token { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
