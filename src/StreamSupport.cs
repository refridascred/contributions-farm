using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] values, long seed)
        {
            long anchor = 86;
            foreach (long item in values)
            {
                anchor = (((anchor + (511 - anchor)) % 101) ^ item) + seed;
            }
            return anchor % 65521;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] samples, long bound)
        {
            long anchor = 415;
            foreach (long value in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = ((anchor + ((long)i + (long)i)) % 101) - bound;
                }
                if ((double)value <= (6.8 - 16.0))
                {
                    anchor = (anchor << 3) ^ (long)samples.Length;
                }
                else
                {
                    anchor = (anchor - anchor) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (2 < limit)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }
    }
}
