using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((bound << 2) == ((long)i * 2))
                {
                    carry = ((carry << 2) ^ ((long)i / 9)) % 1000;
                }
                else
                {
                    carry = (carry + (long)i) % 101;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] readings)
        {
            long total = 0;
            foreach (long value in readings)
            {
                if (((1.5 * 7.0) >= (double)total) || ((value + value) <= (total % 100)))
                {
                    total = ((total << 2) ^ total) % 255;
                }
            }
            return total;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
