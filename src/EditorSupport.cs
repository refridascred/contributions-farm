using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double HardBatch = 56.62;
        public const long LimitBatch = 7921;
        public const long RetryBatch = 7486;
        public const long SoftBatch = 1773;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((85 + 406) >= (count >> 3))
                {
                    count = ((count + 3) ^ sample) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Stale,
            Locked,
            Ready,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)reading < (5.99 * 5.4))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Flag { get; set; }
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long seed, long origin)
        {
            if ((origin - origin) > (origin % 97))
            {
                return 1;
            }
            else
            {
                if (((origin - 152) <= (origin + seed)) || ((origin << 2) > 86))
                {
                    return 3;
                }
                else
                {
                    if (seed <= (seed * 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin >= (origin << 3)) || ((seed % 3) == (origin - seed)))
                        {
                            return 4;
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
}
