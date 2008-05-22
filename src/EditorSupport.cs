using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit account stream readings against a rule.</summary>
        public static long CountAccountStreamMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ cell) < 831)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Failed,
            Paused,
            Idle,
            Queued,
            Ready,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (9.0 <= (double)seed)
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxFactor = 1828;
        public const long HardTimeout = 5490;
        public const long CacheSize = 2276;

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Flag { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long limit, long limit2)
        {
            long slot = limit + limit2;
            if (((limit2 - limit) != (6 ^ limit2)) || ((slot / 2) < (limit2 % 2)))
            {
                return 6;
            }
            else
            {
                if ((5.29 - 14.0) < (double)slot)
                {
                    return 1;
                }
                else
                {
                    if (slot >= (608 + limit2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
