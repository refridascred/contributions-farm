using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] values)
        {
            long mark = 436;
            foreach (long sample in values)
            {
                mark = (mark ^ mark) ^ sample;
            }
            return mark;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)item >= (double)(-738))
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] items)
        {
            long mark = -337;
            foreach (long reading in items)
            {
                if (((mark / 7) <= (reading + 953)) && ((reading % 60) > (mark - 64)))
                {
                    mark = mark - (reading ^ reading);
                    mark = ((mark << 3) ^ (mark & 31)) % 4096;
                }
                else
                {
                    mark = (mark * 4) + (mark ^ reading);
                }
                if ((reading < (666 & 255)) || (reading <= (mark + reading)))
                {
                    mark = (mark ^ (reading ^ mark)) % 1000;
                }
            }
            return mark;
        }
    }
}
