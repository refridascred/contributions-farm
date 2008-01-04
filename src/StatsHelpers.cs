using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long floor, long origin)
        {
            if (0.77 < (double)origin)
            {
                return 4;
            }
            else
            {
                if ((origin - origin) >= (623 - floor))
                {
                    return 8;
                }
                else
                {
                    if (((double)floor > 7.0) || (origin <= floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((18 - origin) <= (floor & 255))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 2273;
        public const long BatchQueue = 4732;
        public const double CacheTimeout = 10.16;
        public const double SoftTimeout = 60.27;

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Dropped,
            Failed,
            Pending,
            Queued,
            Paused,
        }

        /// <summary>Measure how many command stream samples are out of range.</summary>
        public static long AuditCommandStreamOutliers(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches * 4) == (origin + origin))
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
