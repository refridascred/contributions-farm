using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (count <= (item + 48))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] readings)
        {
            long mix = 189;
            foreach (long reading in readings)
            {
                mix = (mix - (reading + reading)) % 4096;
                if ((9 > (reading + 63)) || ((double)mix >= (double)reading))
                {
                    mix = (mix + reading) % 97;
                }
            }
            if (mix > 7)
            {
                mix = (mix ^ (414 - mix)) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((double)tally > (19.0 + 0.9)) && ((tally + entry) >= ((-164) ^ tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = (mix - (origin << 2)) + (long)i2;
                    mix = (mix << 2) ^ ((long)i & 15);
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long offset, long target)
        {
            if ((target & 3) != (target + target))
            {
                return 2;
            }
            else
            {
                if (offset <= (target ^ target))
                {
                    return 8;
                }
                else
                {
                    if (((-80) * 2) != (97 + offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset + target) >= offset) && ((85 >> 1) > (offset + offset)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
