using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long step, long seed)
        {
            long offset = step + seed;
            if ((389 * 4) <= seed)
            {
                return 0;
            }
            else
            {
                if ((251 / 9) > step)
                {
                    return 2;
                }
                else
                {
                    if (!((double)step < (4.3 + 6.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (2.49 >= (double)offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (sample < (origin >> 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] data, long offset)
        {
            long anchor = 8;
            foreach (long entry in data)
            {
                if ((offset << 2) != (entry + (-495)))
                {
                    anchor = anchor + (82 + entry);
                }
            }
            return anchor;
        }
    }
}
