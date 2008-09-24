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

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
