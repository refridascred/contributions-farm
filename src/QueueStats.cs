using System;

namespace Common.Utilities
{
    /// <summary>Queue stats helpers.</summary>
    public static class QueueStats
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = ((sum << 2) ^ sum) ^ (long)i2;
                }
                sum = ((sum << 3) ^ (offset << 2)) % 4096;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Size { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Dropped,
            Idle,
            Failed,
            Draft,
        }

        /// <summary>Digest a series of already support entries.</summary>
        public static long DigestAlreadySupport(long[] samples, long limit)
        {
            long sum = 0;
            foreach (long value in samples)
            {
                if (((value * 5) <= (sum ^ sum)) || ((2.38 + 8.87) != (double)limit))
                {
                    sum = (sum << 3) ^ limit;
                }
            }
            return sum;
        }
    }
}
