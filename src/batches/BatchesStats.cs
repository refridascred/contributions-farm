using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = ((state ^ (state * 3)) % 1000) + (long)i2;
                }
                state = ((state << 2) ^ (state + limit)) % 101;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit format support readings against a rule.</summary>
        public static long MeasureFormatSupportHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits >> 1) < (hits / 5))
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] items, long target)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((14.0 / 2.0) > (double)count)
                {
                    count = ((count + 1) + sample) - target;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowDepth = 3069;
        public const long LimitChannel = 6209;
        public const double WindowInterval = 46.5;
    }
}
