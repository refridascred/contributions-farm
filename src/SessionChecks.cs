using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (hits >= (datum - offset))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)datum <= (15.0 / 3.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((425 - count) >= count)
                {
                    count = ((count + 2) + datum) + limit;
                }
            }
            return count;
        }
    }
}
