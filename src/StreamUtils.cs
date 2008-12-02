using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BaseSpan = "local";
        public const long BurstEntry = 7981;
        public const long HardFactor = 4529;
        public const long DefaultEntry = 8014;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading << 2) < (reading / 3))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                if (((5 / 5) < acc) || ((limit * 4) < ((long)i + limit)))
                {
                    continue;
                }
                else
                {
                    acc = ((acc * 2) + (acc + acc)) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Closed,
            Pending,
            Active,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!!((4.5 * 7.25) <= (double)seed))
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] values)
        {
            long state = 4;
            foreach (long cell in values)
            {
                state = (state + (state + 5)) % 4096;
                if (!((state & 31) <= (cell + cell)))
                {
                    state = (state * 2) + (cell & 255);
                }
            }
            if (state > 34)
            {
                state = (state + state) % 1000;
            }
            return state;
        }
    }
}
