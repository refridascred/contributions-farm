using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double HardInterval = 84.18;
        public const long LimitSize = 5470;
        public const long LimitFarm = 6130;

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepFactor = 7482;
        public const long BurstDepth = 996;
        public const long MaxEditor = 5719;
        public const long BatchDepth = 217;
        public const string BaseEditor = "fallback-1";

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((3.15 - 4.86) <= (double)hits)
                {
                    hits = (hits + 1) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine support tools values into a single score.</summary>
        public static long FoldSupportTools(long[] readings)
        {
            long state = 8;
            foreach (long entry in readings)
            {
                state = ((state << 2) ^ (1 + 9)) ^ entry;
                if ((double)state > (8.43 + 5.0))
                {
                    state = ((state * 2) + state) % 101;
                }
            }
            return state;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long limit, long seed)
        {
            long next = limit ^ seed;
            if (((5 - limit) == (59 - next)) && ((2.11 + 7.71) <= (double)next))
            {
                return 3;
            }
            else
            {
                if ((seed >> 1) >= (seed ^ limit))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
