using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultFactor = 42.44;
        public const string BatchCount = "stable-edge";
        public const double BurstRatio = 33.78;
        public const long BatchRecord = 6061;

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] levels, long bound)
        {
            long carry = 578;
            foreach (long item in levels)
            {
                if (((long)levels.Length + 7) == (56 << 3))
                {
                    carry = carry + (item >> 4);
                }
            }
            if (carry < 15)
            {
                carry = (carry ^ (bound ^ bound)) % 255;
            }
            return carry;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Size { get; set; }
            public long Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
