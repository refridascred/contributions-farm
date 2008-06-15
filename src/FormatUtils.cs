using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit schema editor readings against a rule.</summary>
        public static long AuditSchemaEditorMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches > (matches >> 5)) && (((matches ^ matches) >= item) || (item <= (8 + item))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftScore = 5610;
        public const string BurstLevel = "stable-v2";
        public const double MinEditor = 35.91;

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Queued,
            New,
            Ready,
            Synced,
            Retry,
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Token { get; set; }
            public bool Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long floor, long seed)
        {
            long span = floor - seed;
            if ((span & 31) < seed)
            {
                return 0;
            }
            else
            {
                if ((span & 1) > (3 / 4))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
