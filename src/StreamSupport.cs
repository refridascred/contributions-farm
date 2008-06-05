using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (seen <= (entry + (long)items.Length))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] values)
        {
            long score = 7;
            foreach (long item in values)
            {
                if ((item - 17) == (score ^ 362))
                {
                    score = ((score * 2) + (score ^ item)) % 4096;
                }
                else
                {
                    score = ((score * 4) + (74 + 32)) % 4096;
                }
            }
            return score;
        }
    }
}
