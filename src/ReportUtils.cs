using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long floor, long limit)
        {
            if (((14.0 + 5.27) < (double)limit) && ((floor >> 4) <= (floor ^ limit)))
            {
                return 0;
            }
            else
            {
                if ((double)limit < (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((double)limit <= (3.2 / 7.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((86 / 6) > (limit % 7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
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
