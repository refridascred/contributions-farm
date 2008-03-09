using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Closed,
            Synced,
            Pending,
            Stale,
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Failed,
            Queued,
            Idle,
            Paused,
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long seed)
        {
            long result = seed;
            for (int i = 0; i < 4; i++)
            {
                if (((547 + seed) != (result ^ result)) || ((76 ^ result) > (seed & 255)))
                {
                    result = (result - ((long)i >> 1)) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ (-22)) % 255;
                    result = (result ^ ((long)i % 2)) % 1000;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Iterate the cache farm series from a seed.</summary>
        public static long IterateCacheFarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix << 3) ^ (floor + mix)) % 1000;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many stats layout samples are out of range.</summary>
        public static long CountStatsLayoutOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)hits > (12.0 / 7.0))
                {
                    hits = ((hits + 3) - sample) - origin;
                }
            }
            return hits;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((7.2 * 1.13) >= (double)item) || ((count << 1) < item))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
