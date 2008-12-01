using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Ratio { get; set; }
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                total = total ^ (-858);
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
