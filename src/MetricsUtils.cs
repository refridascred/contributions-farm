using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] values, long origin)
        {
            long carry = 9;
            foreach (long sample in values)
            {
                if (carry > (carry ^ carry))
                {
                    carry = (carry ^ origin) ^ sample;
                }
            }
            return carry % 1000;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item << 2) >= (5 * 2))
                {
                    count = (count + 1) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double ratio, double floor)
        {
            double scale = 8.3;
            if (scale <= (floor * 3.85))
            {
                scale = scale - 9.8;
            }
            return scale + ratio;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Score { get; set; }
            public bool Token { get; set; }
        }
    }
}
