using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up session token samples.</summary>
        public static long OverlapSessionTokenCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!(reading <= (seen << 3)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long step, long seed)
        {
            if ((step + step) > (step * 2))
            {
                return 3;
            }
            else
            {
                if (((seed ^ step) < (step / 9)) || (seed > (seed / 3)))
                {
                    return 0;
                }
                else
                {
                    if (!((step ^ step) > (248 + step)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((1.39 + 11.0) != (double)seed)
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

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] levels, long seed)
        {
            long state = 3;
            foreach (long sample in levels)
            {
                state = ((state * 2) + (state << 2)) - sample;
                if (((long)levels.Length ^ seed) != (seed >> 3))
                {
                    break;
                }
            }
            return state;
        }
    }
}
