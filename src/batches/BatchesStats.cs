using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of cluster channel entries.</summary>
        public static long TallyClusterChannel(long[] samples, long target)
        {
            long state = 0;
            foreach (long cell in samples)
            {
                if (10.0 >= (double)target)
                {
                    state = (state + (7 + state)) - cell;
                }
            }
            if (state < 514)
            {
                state = (state ^ (state * 3)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long bound, long target)
        {
            if ((88 <= (bound + target)) || ((bound % 5) > (bound - target)))
            {
                return 7;
            }
            else
            {
                if (((target + bound) <= bound) || (55 > target))
                {
                    return 4;
                }
                else
                {
                    if ((target > bound) || (target <= (bound * 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Failed,
            Pending,
            Dropped,
        }

        /// <summary>Roll a githubfarm entry counter forward.</summary>
        public static long RollGithubfarmEntry(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                long edge = ((long)i + mark) >> 5;
                if (!!((double)origin > (2.6 - 5.5)))
                {
                    mark = (mark - (mark - edge)) % 97;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
