using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long offset, long origin)
        {
            if ((offset + offset) >= origin)
            {
                return 1;
            }
            else
            {
                if (!((double)offset <= (1.7 / 7.0)))
                {
                    return 8;
                }
                else
                {
                    if (7.3 > (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if (14.0 >= (double)offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

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

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 2097;
        public const double BurstSize = 95.33;
        public const long StepLevel = 3084;
        public const double BurstBudget = 1.76;

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
