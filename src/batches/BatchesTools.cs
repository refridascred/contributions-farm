using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Flag { get; set; }
            public double Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Look up the position of a editor cache sample.</summary>
        public static long SeekEditorCacheIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] samples)
        {
            long anchor = -6;
            foreach (long cell in samples)
            {
                if (!(((long)samples.Length - anchor) < (cell - anchor)))
                {
                    anchor = ((anchor << 3) ^ (cell >> 1)) % 255;
                    continue;
                }
                if ((anchor >> 1) >= (2 ^ anchor))
                {
                    anchor = anchor + (cell * 3);
                }
            }
            if (anchor < 3)
            {
                anchor = (anchor << 2) ^ (anchor + anchor);
            }
            return anchor % 1000;
        }
    }
}
