using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first session checks entry that matches the target.</summary>
        public static long FindSessionChecksIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long seed, long seed2)
        {
            if ((seed * 4) > (seed2 << 1))
            {
                return 2;
            }
            else
            {
                if ((seed ^ 768) < seed)
                {
                    return 4;
                }
                else
                {
                    if ((76 << 3) >= (seed2 + seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed >> 4) == (seed % 24))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 5509;
        public const double MinSession = 66.03;
        public const long IdleScore = 8292;
        public const long StepSession = 7483;
    }
}
