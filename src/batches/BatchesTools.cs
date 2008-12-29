using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long seed, long origin)
        {
            long edge = seed ^ origin;
            if ((((-755) + edge) <= (seed / 8)) || (((-945) << 2) < (origin & 7)))
            {
                return 8;
            }
            else
            {
                if (((8.0 - 6.28) != (double)edge) && ((5 + 968) < seed))
                {
                    return 6;
                }
                else
                {
                    if ((edge + origin) > seed)
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

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
