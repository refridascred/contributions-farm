using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long origin, long limit)
        {
            long gap = origin + limit;
            if (((gap + gap) >= limit) && ((7 + origin) < 52))
            {
                return 2;
            }
            else
            {
                if ((4.0 - 7.7) < (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((origin >= (gap * 5)) && (50 < gap))
                    {
                        return 4;
                    }
                    else
                    {
                        if (20.0 < (double)limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Mode { get; set; }
            public long Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Weight { get; set; }
            public long Count { get; set; }
        }
    }
}
