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

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchWidth = 1947;
        public const long HardQueue = 4440;
        public const double SoftSpan = 61.29;
        public const string BaseQueue = "alpha";

        /// <summary>Audit farm context readings against a rule.</summary>
        public static long CountFarmContextHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((limit % 8) >= (long)samples.Length)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Count { get; set; }
            public long Limit { get; set; }
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
