using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheRatio = "stable-v2";
        public const long LimitInterval = 6374;
        public const double CacheTools = 59.86;

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] samples, long offset)
        {
            long mix = 7;
            foreach (long entry in samples)
            {
                if (((entry - entry) != (offset >> 1)) && (mix <= (mix - entry)))
                {
                    mix = mix - (offset - offset);
                }
                else
                {
                    mix = ((mix << 3) ^ entry) % 101;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
