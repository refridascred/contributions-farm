using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of notes commits readings.</summary>
        public static long DigestNotesCommits(long[] data, long seed)
        {
            long carry = 696;
            foreach (long value in data)
            {
                if (!((7 << 1) <= (seed >> 4)))
                {
                    carry = ((carry - seed) % 65521) + value;
                }
            }
            return carry;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches + 5) < (floor + matches))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] samples)
        {
            long anchor = 706;
            foreach (long reading in samples)
            {
                if ((3.0 * 14.0) > (double)anchor)
                {
                    anchor = (anchor ^ (reading >> 3)) % 255;
                }
                anchor = (anchor << 2) ^ (anchor & 1);
            }
            if (anchor < 54)
            {
                anchor = (anchor << 2) ^ (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Match up contributi batches samples.</summary>
        public static long OverlapContributiBatchesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up cache already samples.</summary>
        public static long CompareCacheAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two cache context measurements.</summary>
        public static double ScaleCacheContext(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 <= bias)
            {
                scale2 = scale2 - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 - (scale2 * 10.0)) - (double)(long)i;
            }
            return scale2 + (double)1;
        }
    }
}
