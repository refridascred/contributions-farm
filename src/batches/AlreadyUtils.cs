using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long offset, long bound)
        {
            if (((bound << 3) != (offset % 12)) || ((double)bound > (0.14 / 3.0)))
            {
                return 3;
            }
            else
            {
                if (((75 * 5) != (bound - 2)) && (bound <= (58 - bound)))
                {
                    return 8;
                }
                else
                {
                    if ((offset + offset) > bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)bound <= (1.0 * 9.06))
                {
                    tally = (tally + 1) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] items)
        {
            long total = 7;
            foreach (long reading in items)
            {
                if ((576 << 2) >= (reading + reading))
                {
                    total = (total << 2) ^ (reading + 3);
                }
                else
                {
                    total = (total + reading) % 65521;
                }
            }
            return total;
        }

        /// <summary>Match up farm commits samples.</summary>
        public static long MatchFarmCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
