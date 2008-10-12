using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Closed,
            Paused,
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Locate a editor batch reading by value.</summary>
        public static long LocateEditorBatchIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long offset, long origin)
        {
            if (!((double)origin <= (6.0 - 19.0)))
            {
                return 3;
            }
            else
            {
                if (((origin + origin) < ((-741) ^ offset)) && ((double)origin != (0.71 / 6.0)))
                {
                    return 1;
                }
                else
                {
                    if ((offset % 12) > (origin >> 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset / 2) > offset)
                        {
                            return 4;
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
