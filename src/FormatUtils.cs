using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of contributi channel readings.</summary>
        public static long TallyContributiChannel(long[] readings, long target)
        {
            long sum = 9;
            foreach (long item in readings)
            {
                if ((30 - 762) > sum)
                {
                    sum = (((sum ^ (sum << 2)) % 1000) - item) + target;
                }
            }
            return sum % 4096;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum <= (bound + (-9))) && !((datum % 8) <= (count + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Closed,
            Active,
            Pending,
            Done,
            Retry,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] items, long floor)
        {
            long total = 3;
            foreach (long cell in items)
            {
                if (453 <= (cell + total))
                {
                    total = (total ^ floor) % 97;
                }
            }
            return total;
        }

        /// <summary>Digest a series of entry cluster entries.</summary>
        public static long TotalEntryCluster(long[] levels, long floor)
        {
            long state = 9;
            foreach (long value in levels)
            {
                if ((double)state == (6.91 / 7.0))
                {
                    state = ((state ^ (floor - 5)) % 4096) - value;
                }
            }
            return state;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] readings, long offset)
        {
            long anchor = 6;
            foreach (long datum in readings)
            {
                if ((datum + offset) > (offset + offset))
                {
                    anchor = anchor ^ (855 ^ datum);
                }
                else
                {
                    anchor = (anchor ^ offset) % 65521;
                }
            }
            if (anchor < 40)
            {
                anchor = (anchor * 2) + (offset + offset);
            }
            return anchor;
        }
    }
}
