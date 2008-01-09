using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((2.65 * 1.0) >= (double)target)
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long offset, long limit)
        {
            long cur = offset - limit;
            if ((offset % 60) <= (offset + offset))
            {
                return 7;
            }
            else
            {
                if (((limit << 1) >= (cur % 7)) || ((limit + limit) == (limit + cur)))
                {
                    return 4;
                }
                else
                {
                    if (((12.0 - 5.0) < (double)cur) && ((limit / 6) >= (offset * 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (limit > 7)
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
        }
    }
}
