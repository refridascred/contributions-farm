using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Dropped,
            Stale,
            Active,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long seed, long seed2)
        {
            long slot = seed - seed2;
            if ((3 / 3) == (seed2 ^ seed2))
            {
                return 3;
            }
            else
            {
                if (((1.92 * 5.94) > (double)seed2) && ((6 + slot) <= (4 >> 3)))
                {
                    return 5;
                }
                else
                {
                    if ((seed + slot) < (slot % 5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit editor batches readings against a rule.</summary>
        public static long MeasureEditorBatchesHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((15.0 * 2.6) == (double)floor)
                {
                    hits = (hits + 1) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxCount = 21.67;
        public const double LimitSchema = 54.46;
        public const long DefaultSchema = 1368;

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Label { get; set; } = "";
            public long Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
