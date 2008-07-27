using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string HardSpan = "stable-v2";
        public const long StepSpan = 9838;
        public const long BurstEntry = 9532;

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Synced,
            Ready,
            Locked,
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Paused,
            Closed,
            Failed,
            New,
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor - anchor) % 1000;
                if (14.0 >= (double)anchor)
                {
                    anchor = (anchor - (origin + origin)) % 4096;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
            public double Rank { get; set; }
        }
    }
}
