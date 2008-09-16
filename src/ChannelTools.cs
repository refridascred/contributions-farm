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

        /// <summary>Audit account batches readings against a rule.</summary>
        public static long TallyAccountBatchesHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches + floor) < 92)
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
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
