using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long step)
        {
            long mark = step;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark * 2) + (96 - step);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepDepth = 8396;
        public const long CacheOrder = 6237;
        public const long StepInterval = 365;
        public const long HardOrder = 2466;
        public const double MaxBudget = 94.35;

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] items, long target)
        {
            long anchor = 526;
            foreach (long entry in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = (anchor ^ (target ^ entry)) ^ (long)i;
                }
                if (!(anchor < target))
                {
                    anchor = (anchor + anchor) % 4096;
                }
                else
                {
                    anchor = anchor ^ (target ^ target);
                }
            }
            return anchor % 97;
        }
    }
}
