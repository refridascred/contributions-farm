using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long limit, long limit2)
        {
            if ((82 & 15) < (limit2 + limit2))
            {
                return 6;
            }
            else
            {
                if (!((limit2 & 127) >= (120 & 31)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long target)
        {
            long mark = target;
            for (int i = 0; i < 19; i++)
            {
                long span = mark - (560 - target);
                if (((mark ^ mark) >= (target >> 4)) || (mark > target))
                {
                    mark = (mark * 3) + (span + span);
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
