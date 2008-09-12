using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)tally > (double)item)
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] items, long bound)
        {
            long sum = 8;
            foreach (long sample in items)
            {
                if (sample > (bound + bound))
                {
                    sum = ((sum << 2) ^ (sum % 3)) % 1000;
                }
                else
                {
                    sum = (sum ^ bound) % 97;
                }
            }
            return sum;
        }
    }
}
