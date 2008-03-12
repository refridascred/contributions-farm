using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit format cache readings against a rule.</summary>
        public static long AuditFormatCacheMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((79 + 554) > hits)
                {
                    hits = ((hits + 2) + reading) + limit;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] values, long limit)
        {
            long score = 46;
            foreach (long item in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    score = ((score - (limit ^ score)) % 101) + (long)i;
                }
                if ((double)item > (16.0 + 12.0))
                {
                    score = (score - (limit / 5)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
