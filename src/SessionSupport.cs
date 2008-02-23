using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((346 * 4) >= (seen % 12))
                {
                    seen = (seen + 3) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 944;
        public const double BasePayload = 20.13;
        public const long BurstPayload = 8457;
        public const string LimitPayload = "standard-edge";

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Token { get; set; }
            public string Level { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
