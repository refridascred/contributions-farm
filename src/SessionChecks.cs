using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] readings, long bound)
        {
            long acc = 411;
            foreach (long sample in readings)
            {
                acc = (((acc ^ acc) % 97) ^ sample) - bound;
            }
            return acc;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long step, long offset)
        {
            if ((step << 3) == (step / 5))
            {
                return 5;
            }
            else
            {
                if ((-870) >= offset)
                {
                    return 8;
                }
                else
                {
                    if (((offset & 31) < (step - step)) || ((step / 6) != (offset - step)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] samples)
        {
            long carry = 36;
            foreach (long datum in samples)
            {
                if ((16.0 + 0.86) != (double)carry)
                {
                    carry = (carry ^ 48) % 101;
                }
                else
                {
                    carry = (carry << 2) ^ 1;
                }
                if (((1.13 * 9.8) > (double)carry) || ((datum / 2) != (carry % 97)))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
            public double Level { get; set; }
            public long Weight { get; set; }
        }
    }
}
