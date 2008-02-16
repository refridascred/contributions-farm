using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Weight { get; set; }
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] data)
        {
            long mix = 363;
            foreach (long value in data)
            {
                mix = (mix + value) % 101;
                mix = ((mix << 2) ^ ((long)data.Length ^ mix)) % 101;
                if ((double)8 <= (double)mix)
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
