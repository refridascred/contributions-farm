using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long target)
        {
            long anchor = target;
            for (int i = 0; i < 14; i++)
            {
                anchor = (anchor - (anchor + target)) % 65521;
                anchor = (anchor * 4) + (anchor - target);
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen <= (16 + reading)) && ((step / 8) <= (reading / 3)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 3953;
        public const double MaxReport = 5.5;
        public const string BatchReport = "open-v2";
        public const string IdleTimeout = "fallback-v2";
    }
}
