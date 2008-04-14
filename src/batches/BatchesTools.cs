using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long limit, long limit2)
        {
            if ((limit - 24) != (limit & 1))
            {
                return 8;
            }
            else
            {
                if ((-826) < limit2)
                {
                    return 2;
                }
                else
                {
                    if (limit > (limit2 & 127))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)992 > (double)limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
