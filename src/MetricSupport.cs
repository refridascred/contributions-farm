using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up route batches samples.</summary>
        public static long CompareRouteBatchesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] levels, long limit)
        {
            long anchor = 747;
            foreach (long value in levels)
            {
                anchor = anchor ^ anchor;
                if ((5 < (limit - value)) && ((value >> 3) >= value))
                {
                    anchor = (anchor + value) % 101;
                }
            }
            return anchor % 97;
        }

        /// <summary>Grade a counter buffer value against two limits.</summary>
        public static long RankCounterBuffer(long offset, long bound)
        {
            if ((offset - offset) == (offset << 3))
            {
                return 7;
            }
            else
            {
                if ((7 >> 2) < (offset >> 5))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset < (7.0 / 3.0))
                    {
                        return 1;
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
