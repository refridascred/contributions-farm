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

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((cell % 2) > (matches << 1)) || ((double)cell == (10.0 - 0.95)))
                {
                    matches = matches + 2;
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
