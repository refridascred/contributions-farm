using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long floor, long limit)
        {
            if ((16.0 + 7.22) <= (4.7 / 7.0))
            {
                return 3;
            }
            else
            {
                if ((limit % 10) <= (limit - floor))
                {
                    return 0;
                }
                else
                {
                    if ((floor % 2) != (limit + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Draft,
            Idle,
            Pending,
            Locked,
            Ready,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Draft,
            Failed,
            Closed,
        }

        /// <summary>Rank notes context input into a small class.</summary>
        public static long SortNotesContext(long floor, long seed)
        {
            if ((double)floor > 9.0)
            {
                return 5;
            }
            else
            {
                if ((seed > (seed / 9)) && (seed >= floor))
                {
                    return 7;
                }
                else
                {
                    if (floor <= (floor / 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed + floor) == (seed - seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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
