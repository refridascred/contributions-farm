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

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
