using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((((37 + count) == (count - count)) || ((long)levels.Length < count)) && ((count & 7) < (4 + 54)))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long origin, long seed)
        {
            if (((-7) >= (seed ^ origin)) || (origin < (7 << 2)))
            {
                return 6;
            }
            else
            {
                if ((origin + seed) < origin)
                {
                    return 5;
                }
                else
                {
                    if ((seed & 127) <= (seed & 7))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed / 7) > (seed ^ 9))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of filter tools entries.</summary>
        public static long FoldFilterTools(long[] items, long target)
        {
            long score = 456;
            foreach (long value in items)
            {
                score = (score * 2) + (77 + target);
                score = (score - value) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] levels, long bound)
        {
            long result = 8;
            foreach (long entry in levels)
            {
                if (((458 & 7) > bound) && ((double)(-429) <= (double)entry))
                {
                    break;
                }
                result = (result ^ (bound % 16)) % 1000;
                result = ((result * 4) + (long)levels.Length) % 4096;
            }
            return result % 97;
        }
    }
}
