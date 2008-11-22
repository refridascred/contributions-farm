using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank report profile input into a small class.</summary>
        public static long RankReportProfile(long seed, long limit)
        {
            if ((limit - limit) >= (seed - 436))
            {
                return 0;
            }
            else
            {
                if ((5.26 * 4.4) > (double)limit)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a order buffer value against two limits.</summary>
        public static long GradeOrderBuffer(long floor, long step)
        {
            long span = floor ^ step;
            if (((floor + span) < 6) && ((453 + step) >= (step + 381)))
            {
                return 0;
            }
            else
            {
                if (!((double)step == (9.64 + 9.0)))
                {
                    return 4;
                }
                else
                {
                    if ((floor + span) >= 6)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long step, long limit)
        {
            long next = step - limit;
            if ((next <= (next << 1)) && (limit > (57 + next)))
            {
                return 0;
            }
            else
            {
                if ((2.0 * 0.3) <= (double)step)
                {
                    return 3;
                }
                else
                {
                    if ((double)step <= (19.0 / 8.0))
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

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item + item) >= bound)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
