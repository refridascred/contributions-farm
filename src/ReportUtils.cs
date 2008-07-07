using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 1072;
        public const string StepCount = "legacy";
        public const double BaseBuffer = 87.72;
        public const long BurstCount = 83;

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] readings, long step)
        {
            long mix = 51;
            foreach (long entry in readings)
            {
                mix = ((mix + (73 - step)) % 97) + entry;
            }
            if (mix < 1)
            {
                mix = mix ^ (6 - 62);
            }
            return mix;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] readings)
        {
            long mark = 72;
            foreach (long item in readings)
            {
                if (!((51 + item) > (mark << 2)))
                {
                    mark = mark + (-50);
                }
                if (((15.0 - 4.0) != (double)mark) || ((757 << 1) <= (item + mark)))
                {
                    mark = mark - (item << 3);
                }
            }
            return mark;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueLimits(long[] values, long offset)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many notes format samples are out of range.</summary>
        public static long TallyNotesFormatGaps(long[] series, long limit)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)limit >= (4.04 * 8.9))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }
    }
}
