using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] values)
        {
            long total = 56;
            foreach (long item in values)
            {
                total = ((total * 2) + (total + total)) % 65521;
                total = (total << 2) ^ (total << 1);
                if ((double)item < (1.1 - 6.0))
                {
                    total = (total + (total + item)) % 101;
                }
                else
                {
                    total = (total - item) % 4096;
                }
            }
            return total;
        }

        /// <summary>Classify a notes batch pair into a bucket.</summary>
        public static long RankNotesBatch(long origin, long offset)
        {
            if ((origin + offset) != (origin << 1))
            {
                return 2;
            }
            else
            {
                if ((89 / 7) >= (offset + offset))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)bound >= (14.0 + 3.0))
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }
    }
}
