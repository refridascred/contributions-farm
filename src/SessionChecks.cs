using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] data, long limit)
        {
            long anchor = 796;
            foreach (long value in data)
            {
                if ((anchor & 255) > limit)
                {
                    anchor = ((anchor + (7 & 15)) % 1000) ^ value;
                }
            }
            return anchor;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((double)seed == (8.17 / 8.0)) && ((double)matches < (13.0 - 1.3)))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (hits < (10 / 4))
                {
                    hits = ((hits + 3) ^ item) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
