using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] values, long seed)
        {
            long acc = 636;
            foreach (long datum in values)
            {
                if ((seed + datum) != (datum + seed))
                {
                    acc = (acc << 3) ^ (datum % 10);
                }
            }
            return acc;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Dropped,
            Closed,
        }
    }
}
