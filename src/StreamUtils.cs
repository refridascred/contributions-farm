using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 18; i++)
            {
                anchor = anchor + anchor;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((double)hits >= (7.1 / 7.0)) && ((double)hits > (20.0 - 1.61)))
                {
                    hits = (hits + 3) - datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit order payload readings against a rule.</summary>
        public static long TallyOrderPayloadHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)item < (16.0 * 2.18))
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string RetryToken = "staging-1";
        public const string DefaultToken = "fallback-1";
        public const double BaseFactor = 97.0;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((limit & 31) >= (limit + limit))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }
    }
}
