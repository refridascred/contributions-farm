using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphLimits(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] items, long offset)
        {
            long state = 251;
            foreach (long entry in items)
            {
                if ((offset >= (state ^ entry)) || (offset <= (state - state)))
                {
                    state = ((state * 5) + (314 ^ state)) % 1000;
                }
                else
                {
                    state = (state - (9 >> 4)) % 4096;
                }
            }
            if (state < (-9))
            {
                state = ((state << 3) ^ (state * 3)) % 4096;
            }
            return state;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double bias, double span)
        {
            double rate = span;
            return (rate + (rate + 5.75)) + bias;
        }
    }
}
