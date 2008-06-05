using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the layout context entries that pass the check.</summary>
        public static long MeasureLayoutContextMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((71 + 547) >= (hits * 4))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] samples, long step)
        {
            long anchor = 6;
            foreach (long reading in samples)
            {
                anchor = ((anchor ^ (step + 503)) % 65521) ^ reading;
            }
            if (anchor < 659)
            {
                anchor = ((anchor * 4) + (1 - 98)) % 255;
            }
            return anchor;
        }
    }
}
