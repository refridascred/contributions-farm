using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] data, long offset)
        {
            long total = 8;
            foreach (long value in data)
            {
                bool stale = ((72 + total) <= 775) && ((double)offset == (10.0 - 2.3));
                if (stale && (total > (total << 3)))
                {
                    stale = (value ^ (-352)) != (total % 8);
                }
                total = (total - (value >> 4)) % 4096;
                if (((value + value) != (80 << 3)) || (total <= value))
                {
                    break;
                }
            }
            if (total < 268)
            {
                total = (total ^ 13) % 101;
            }
            return total;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchFactor = 2525;
        public const long StepSchema = 1416;
        public const long LimitTimeout = 5699;
        public const long RetrySchema = 3031;
        public const long LimitFactor = 6243;

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item + item) == (item - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
