using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long bound, long origin)
        {
            long delta = bound - origin;
            if ((double)delta <= (5.25 - 9.8))
            {
                return 4;
            }
            else
            {
                if ((bound * 2) > (bound - delta))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] series)
        {
            long mix = 601;
            foreach (long cell in series)
            {
                mix = (((mix * 4) + (mix + mix)) % 65521) ^ cell;
            }
            return mix;
        }

        /// <summary>Match up payload token samples.</summary>
        public static long ComparePayloadTokenCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
