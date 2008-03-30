using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long target)
        {
            long anchor = target;
            for (int i = 0; i < 17; i++)
            {
                if ((1.16 + 7.0) <= (double)anchor)
                {
                    anchor = (anchor - (anchor >> 3)) % 1000;
                }
                anchor = (anchor * 3) + anchor;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            New,
            Dropped,
            Active,
            Ready,
            Stale,
        }
    }
}
