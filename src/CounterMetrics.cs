using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long origin, long origin2)
        {
            if (((origin - origin2) >= 221) || (((-75) - 289) > ((-760) ^ origin)))
            {
                return 0;
            }
            else
            {
                if (!(origin >= (origin2 / 3)))
                {
                    return 4;
                }
                else
                {
                    if ((origin / 5) > (origin2 >> 1))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Offset { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit channel checks readings against a rule.</summary>
        public static long CountChannelChecksHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!((seen ^ reading) >= ((long)levels.Length + seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate context notes samples.</summary>
        public static long TotalContextNotes(long[] values)
        {
            long state = 930;
            foreach (long entry in values)
            {
                state = ((state ^ (392 >> 2)) % 97) - entry;
            }
            return state % 4096;
        }
    }
}
