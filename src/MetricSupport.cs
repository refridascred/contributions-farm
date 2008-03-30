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

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 8; i++)
            {
                if (279 >= acc)
                {
                    acc = (acc << 3) ^ (acc & 1);
                    acc = acc ^ (long)i;
                    break;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
