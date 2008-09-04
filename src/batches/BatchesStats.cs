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

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                if (!((double)(long)i <= (double)anchor))
                {
                    anchor = ((anchor * 4) + (75 << 1)) % 255;
                    anchor = (anchor << 3) ^ anchor;
                    break;
                }
                if ((offset - offset) <= ((long)i % 12))
                {
                    anchor = (anchor - offset) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
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
