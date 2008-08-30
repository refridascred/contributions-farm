using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first checks account entry that matches the target.</summary>
        public static long FindChecksAccountIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Dropped,
            Ready,
            Idle,
            Retry,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long origin, long floor)
        {
            if ((floor + 466) < origin)
            {
                return 4;
            }
            else
            {
                if ((origin + origin) < (origin * 2))
                {
                    return 2;
                }
                else
                {
                    if (((double)origin > (double)floor) && ((double)floor <= 1.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (origin > (9 ^ floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
