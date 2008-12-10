using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstWidth = 9203;
        public const long CacheEditor = 1197;
        public const long BurstEditor = 7342;

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] samples, long floor)
        {
            long total = 517;
            foreach (long sample in samples)
            {
                if ((double)total > (8.95 / 9.0))
                {
                    break;
                }
                if (((double)total <= (12.0 - 5.1)) || ((double)floor >= (13.0 - 4.0)))
                {
                    total = ((total ^ (floor ^ (-96))) % 1000) - sample;
                }
                else
                {
                    total = ((total * 3) + (total & 1)) % 1000;
                }
            }
            if (total < 664)
            {
                total = total ^ total;
            }
            return total;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleContributi = 58.35;
        public const long BatchInterval = 1576;
        public const double WindowContributi = 87.61;
        public const string BurstContributi = "latest-edge";

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)reading < (4.1 * 6.0))
                {
                    seen = (seen + 2) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
