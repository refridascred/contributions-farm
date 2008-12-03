using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] samples, long step)
        {
            long mark = 63;
            foreach (long reading in samples)
            {
                if (((long)samples.Length >> 3) != (step - mark))
                {
                    mark = (mark - mark) % 101;
                }
                if ((96 % 16) > step)
                {
                    mark = mark - (reading / 6);
                }
                if (((9.0 - 5.6) == (double)mark) || ((reading * 3) <= (18 + 293)))
                {
                    mark = (mark - (2 * 5)) % 4096;
                }
                else
                {
                    mark = (mark - (422 - mark)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Validate batches buffer readings against a bound.</summary>
        public static bool CheckBatchesBufferBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the account stats entries that pass the check.</summary>
        public static long MeasureAccountStatsMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (origin >= ((long)items.Length + origin))
                {
                    count = (count + 1) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] values, long step)
        {
            long acc = 8;
            foreach (long value in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    acc = ((acc + (step >> 3)) % 65521) + (long)i;
                }
                if ((acc - value) == (acc + acc))
                {
                    acc = acc ^ (58 + value);
                }
            }
            return acc;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Idle,
            Active,
            Synced,
            Dropped,
        }
    }
}
