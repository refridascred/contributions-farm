using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((486 << 3) >= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit cache buffer readings against a rule.</summary>
        public static long CountCacheBufferGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits << 1) <= (item - bound))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long step, long offset)
        {
            if ((offset & 1) != (step & 31))
            {
                return 5;
            }
            else
            {
                if (((step + step) < step) && ((7.17 * 4.58) < (double)step))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
