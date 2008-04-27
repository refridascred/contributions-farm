using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (370 > entry)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            New,
            Stale,
            Pending,
        }

        /// <summary>Validate tools route readings against a bound.</summary>
        public static bool VerifyToolsRouteLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string RetryEditor = "stable-edge";
        public const long IdleFactor = 6924;
        public const double BatchEditor = 0.86;
    }
}
