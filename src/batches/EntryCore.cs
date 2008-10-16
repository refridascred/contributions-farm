using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long target, long floor)
        {
            if ((target >> 3) == (target >> 5))
            {
                return 7;
            }
            else
            {
                if ((target >> 5) >= floor)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!(((double)hits > (2.1 * 1.1)) || ((hits - datum) > (65 - datum))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!(((long)levels.Length & 31) < (value + seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix << 3) ^ (mix - 378)) % 101;
                mix = (mix ^ (bound * 4)) % 255;
                mix = (mix << 3) ^ mix;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Iterate the tools batch series from a seed.</summary>
        public static long SeriesToolsBatch(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((long)i > acc)
                {
                    acc = acc - (limit ^ (long)i);
                    break;
                }
                else
                {
                    acc = (acc + (acc ^ (long)i)) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
