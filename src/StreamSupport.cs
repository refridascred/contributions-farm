using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Draft,
            Ready,
            Locked,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Count { get; set; }
            public bool Stamp { get; set; }
            public long Rank { get; set; }
            public double Limit { get; set; }
        }
    }
}
