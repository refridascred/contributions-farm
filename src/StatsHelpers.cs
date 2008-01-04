using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long target, long limit)
        {
            long next = target ^ limit;
            if (!(2.0 <= (double)limit))
            {
                return 4;
            }
            else
            {
                if (((target + target) < (target + limit)) || ((next - next) <= (30 / 3)))
                {
                    return 6;
                }
                else
                {
                    return 3;
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
