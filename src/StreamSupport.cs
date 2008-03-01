using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] values, long target)
        {
            long mark = 294;
            foreach (long entry in values)
            {
                mark = mark + (mark & 31);
                mark = (mark + (51 * 4)) % 4096;
                if ((mark * 4) == (entry - target))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Level { get; set; }
            public string Count { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
