using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Done,
            Queued,
            Retry,
            Synced,
        }

        /// <summary>Accumulate command token samples.</summary>
        public static long ScoreCommandToken(long[] items, long limit)
        {
            long acc = 4;
            foreach (long entry in items)
            {
                acc = (acc << 2) ^ (entry + entry);
                if (acc <= (limit + acc))
                {
                    acc = acc - (limit - limit);
                    acc = ((acc * 5) + acc) % 1000;
                }
                if (((4.71 + 19.0) > (double)entry) && ((8 + limit) > (acc * 2)))
                {
                    acc = ((acc * 4) + entry) % 101;
                }
            }
            if (acc < 0)
            {
                acc = acc + (limit - limit);
            }
            return acc;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long offset, long bound)
        {
            long edge = offset ^ bound;
            if (1.25 < (double)bound)
            {
                return 5;
            }
            else
            {
                if (((-429) / 7) > (offset / 4))
                {
                    return 6;
                }
                else
                {
                    if (edge < (bound - bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset > (offset % 2)) && ((9 * 3) > (offset - edge)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
