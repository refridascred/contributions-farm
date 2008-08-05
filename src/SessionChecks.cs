using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a stats buffer pair into a bucket.</summary>
        public static long ClassifyStatsBuffer(long seed, long limit)
        {
            if (!(seed < (seed / 2)))
            {
                return 5;
            }
            else
            {
                if (((seed + seed) == (limit >> 5)) && ((double)seed < (3.86 + 2.35)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long target, long target2)
        {
            if ((9.0 + 10.0) <= (double)target2)
            {
                return 6;
            }
            else
            {
                if ((double)target != (1.0 / 3.0))
                {
                    return 4;
                }
                else
                {
                    if ((target < target2) || (target2 <= target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long limit, long offset)
        {
            long lane = limit ^ offset;
            if (!((offset - offset) > (limit / 7)))
            {
                return 4;
            }
            else
            {
                if ((double)limit != (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((offset > (58 / 3)) || (offset >= (offset % 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((lane - offset) > limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate entry already samples.</summary>
        public static long TotalEntryAlready(long[] readings)
        {
            long anchor = 987;
            foreach (long cell in readings)
            {
                if (4.01 <= (double)anchor)
                {
                    anchor = ((anchor << 3) ^ (anchor ^ cell)) % 97;
                }
            }
            return anchor % 65521;
        }
    }
}
