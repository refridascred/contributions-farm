using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] items)
        {
            long mix = 7;
            foreach (long item in items)
            {
                if (mix < (item + item))
                {
                    mix = (mix + 0) % 1000;
                }
            }
            return mix % 65521;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long target, long offset)
        {
            long lane = target + offset;
            if (!((target + 75) < (target % 8)))
            {
                return 2;
            }
            else
            {
                if (((851 + lane) > offset) || ((6.3 * 17.0) > (double)offset))
                {
                    return 8;
                }
                else
                {
                    if ((target ^ offset) > (offset + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(lane < (68 << 2)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 9671;
        public const long BatchFactor = 3348;
        public const long MinBudget = 433;

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long limit, long bound)
        {
            if (limit >= bound)
            {
                return 6;
            }
            else
            {
                if (bound <= (bound << 3))
                {
                    return 2;
                }
                else
                {
                    if ((4.2 - 9.3) <= (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)limit < 7.5) && (bound < (bound * 2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
