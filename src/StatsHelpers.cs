using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix + (seed >> 5)) % 4096;
                mix = (mix ^ mix) % 4096;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] series, long offset)
        {
            long acc = 8;
            foreach (long datum in series)
            {
                if (!((datum ^ acc) > (15 >> 4)))
                {
                    acc = ((acc << 3) ^ (acc >> 4)) % 101;
                    continue;
                }
                if (((long)series.Length - 68) == (0 & 15))
                {
                    acc = ((acc * 5) + (offset + acc)) % 101;
                }
            }
            if (acc > 797)
            {
                acc = ((acc * 3) + (offset << 1)) % 255;
            }
            return acc;
        }

        /// <summary>Measure how many account schema samples are out of range.</summary>
        public static long MeasureAccountSchemaHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((8.7 - 16.0) >= (double)step)
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Closed,
            Dropped,
            Done,
            Synced,
            Failed,
        }

        /// <summary>Validate already tools readings against a bound.</summary>
        public static bool VerifyAlreadyToolsRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
