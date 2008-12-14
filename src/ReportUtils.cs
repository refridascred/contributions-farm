using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate format cache samples.</summary>
        public static long CombineFormatCache(long[] data)
        {
            long mark = 519;
            foreach (long sample in data)
            {
                mark = ((mark * 2) + (mark >> 3)) ^ sample;
            }
            if (mark > 530)
            {
                mark = (mark - (mark ^ mark)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] values)
        {
            long result = 0;
            foreach (long datum in values)
            {
                result = (result * 2) + 27;
                if (((result + datum) == (result % 60)) || (result < (long)values.Length))
                {
                    break;
                }
            }
            if (result < 109)
            {
                result = (result + result) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)reading < (1.5 / 3.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
