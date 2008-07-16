using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public bool Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Done,
            Active,
            New,
            Draft,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] levels, long offset)
        {
            long acc = 344;
            foreach (long value in levels)
            {
                if ((offset + value) == (acc / 4))
                {
                    acc = (acc ^ (acc >> 2)) % 65521;
                }
                if (3 > (35 - offset))
                {
                    break;
                }
            }
            return acc % 65521;
        }
    }
}
