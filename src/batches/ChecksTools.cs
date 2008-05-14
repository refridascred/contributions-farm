using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)count >= 9.5)
                {
                    count = (count + 1) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit route order readings against a rule.</summary>
        public static long TallyRouteOrderHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)hits <= (1.0 - 4.88))
                {
                    hits = ((hits + 1) ^ sample) + bound;
                }
            }
            return hits;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] levels)
        {
            long score = 69;
            foreach (long entry in levels)
            {
                if ((score < (score % 8)) && ((entry - score) > (entry + (-9))))
                {
                    score = ((score * 2) + (19 % 2)) % 1000;
                }
                else
                {
                    score = score ^ (entry + score);
                }
            }
            if (score > 758)
            {
                score = score ^ (score * 5);
            }
            return score;
        }
    }
}
