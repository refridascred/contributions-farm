using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up payload route samples.</summary>
        public static long OverlapPayloadRouteCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Token { get; set; }
            public bool Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
            public bool Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 5437;
        public const long IdleSpan = 1810;
        public const double BaseScore = 30.69;
        public const long IdleContext = 7801;
        public const double IdleScore = 57.89;
    }
}
