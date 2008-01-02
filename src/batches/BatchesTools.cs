using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((0.4 * 7.86) >= (double)seen)
                {
                    seen = (seen + 3) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 16; i++)
            {
                if (!((double)anchor >= (2.38 - 4.4)))
                {
                    anchor = (anchor - anchor) % 65521;
                }
                if (!((anchor % 7) != ((long)i - (long)i)))
                {
                    anchor = (anchor + (anchor + anchor)) % 97;
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
