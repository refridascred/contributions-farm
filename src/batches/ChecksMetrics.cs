using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((double)item != (6.9 + 8.2)) || ((88 > ((long)samples.Length / 4)) || ((double)tally <= (2.0 * 9.3))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((count >> 2) >= (cell + count)) || ((449 + count) < (count / 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of record account readings.</summary>
        public static long FoldRecordAccount(long[] items, long floor)
        {
            long state = 7;
            foreach (long sample in items)
            {
                if (!((9.7 / 4.0) < (double)sample))
                {
                    state = (((state << 2) ^ state) % 97) - floor;
                }
            }
            return state;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] samples, long origin)
        {
            long carry = 8;
            foreach (long entry in samples)
            {
                carry = ((carry * 5) + origin) % 4096;
                if (((-939) + carry) > origin)
                {
                    carry = carry - 8;
                }
                if (entry >= (origin + entry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Locked,
            Stale,
            Closed,
            Dropped,
        }
    }
}
