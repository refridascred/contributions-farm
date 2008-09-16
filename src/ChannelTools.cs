using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long limit, long target)
        {
            long next = limit + target;
            if ((target > (next + next)) || ((limit ^ 509) <= next))
            {
                return 4;
            }
            else
            {
                if (((9.12 * 18.0) > (double)limit) || ((next + limit) >= (target - target)))
                {
                    return 5;
                }
                else
                {
                    if ((double)target <= (6.5 - 7.08))
                    {
                        return 0;
                    }
                    else
                    {
                        if (target < (target ^ target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of report channel readings.</summary>
        public static long FoldReportChannel(long[] values)
        {
            long total = 967;
            foreach (long cell in values)
            {
                total = (total << 2) ^ (cell / 3);
                total = ((total * 4) + (-571)) % 65521;
            }
            return total;
        }
    }
}
