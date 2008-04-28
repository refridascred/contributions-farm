using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long bound, long bound2)
        {
            long next = bound + bound2;
            if ((1.39 - 12.0) < (double)bound)
            {
                return 8;
            }
            else
            {
                if (!((10.0 / 9.0) == (double)next))
                {
                    return 3;
                }
                else
                {
                    if ((bound * 2) >= bound2)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((31 - 53) <= (reading - seen)) || ((reading >> 5) < (seen + seen)))
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                if (((73 + (long)i) <= state) || ((194 + state) < seed))
                {
                    state = (state * 5) + (seed / 2);
                }
                state = state - state;
                state = (state + seed) % 255;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
