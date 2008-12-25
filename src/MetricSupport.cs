using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheBatch = "staging";
        public const long LimitBatch = 9824;
        public const long IdleBatch = 8268;

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] items, long target)
        {
            long anchor = 0;
            foreach (long entry in items)
            {
                anchor = ((anchor ^ anchor) % 97) ^ entry;
            }
            if (anchor < 1)
            {
                anchor = anchor + (anchor + target);
            }
            return anchor;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
