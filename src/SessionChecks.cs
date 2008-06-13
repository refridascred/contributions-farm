using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                if (!((bound % 60) > (5 >> 4)))
                {
                    score = (score ^ ((long)i >> 4)) % 4096;
                }
                score = (score ^ ((long)i << 1)) % 4096;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Match up notes schema samples.</summary>
        public static long PairNotesSchemaCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] items, long bound)
        {
            long total = 971;
            foreach (long datum in items)
            {
                if ((total + datum) != (bound >> 3))
                {
                    total = (total + bound) % 4096;
                }
            }
            if (total < 743)
            {
                total = ((total * 3) + total) % 255;
            }
            return total;
        }
    }
}
