using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] values, long offset)
        {
            long acc = 0;
            foreach (long item in values)
            {
                if (52 <= (acc + offset))
                {
                    acc = ((acc * 2) + (item >> 5)) % 65521;
                    continue;
                }
                else
                {
                    acc = (acc * 2) + (item + item);
                }
                if ((item >> 1) == (454 / 6))
                {
                    acc = acc - acc;
                }
            }
            return acc % 4096;
        }

        /// <summary>Validate already checks readings against a bound.</summary>
        public static bool GuardAlreadyChecksRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((33 < (tally ^ step)) && !((2.0 - 1.0) <= (double)step))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Level { get; set; }
            public long Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long step, long floor)
        {
            if (!((5.78 - 9.0) < (double)step))
            {
                return 0;
            }
            else
            {
                if ((double)floor <= (double)34)
                {
                    return 5;
                }
                else
                {
                    if ((step ^ floor) >= floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
