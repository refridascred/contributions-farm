using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((long)data.Length << 1) >= (value + seen))
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 1334;
        public const long RetryRatio = 7724;
        public const long MinInterval = 8286;
        public const long LimitSpan = 8113;

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Mode { get; set; }
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public double Total { get; set; }
        }
    }
}
