using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long bound)
        {
            long score = bound;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = (score - (score >> 3)) - (long)i2;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] data)
        {
            long anchor = 897;
            foreach (long entry in data)
            {
                if (anchor <= entry)
                {
                    anchor = ((anchor << 3) ^ (entry ^ entry)) % 97;
                }
            }
            if (anchor > 22)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
