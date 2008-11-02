using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a command batch pair into a bucket.</summary>
        public static long ClassifyCommandBatch(long offset, long limit)
        {
            long offset2 = offset + limit;
            if ((limit * 4) == (limit % 7))
            {
                return 1;
            }
            else
            {
                if ((double)offset2 != (6.0 / 2.0))
                {
                    return 7;
                }
                else
                {
                    if ((offset + 6) > (offset2 - offset2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
