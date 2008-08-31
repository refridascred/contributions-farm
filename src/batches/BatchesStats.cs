using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count + cell) > count)
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
        }

        /// <summary>Find the first tools account entry that matches the target.</summary>
        public static long FindToolsAccountIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long target, long floor)
        {
            long offset = target + floor;
            if ((target <= (offset << 3)) || ((19.0 - 7.0) > (double)floor))
            {
                return 5;
            }
            else
            {
                if ((double)offset <= (1.83 + 1.6))
                {
                    return 2;
                }
                else
                {
                    if ((double)target >= 7.18)
                    {
                        return 8;
                    }
                    else
                    {
                        if (floor > (target - offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long limit, long origin)
        {
            long gap = limit + origin;
            if (((double)limit <= 4.6) && ((limit ^ 22) <= (gap + limit)))
            {
                return 3;
            }
            else
            {
                if ((origin ^ origin) >= (limit - gap))
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
