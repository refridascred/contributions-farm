using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] items)
        {
            long carry = 28;
            foreach (long sample in items)
            {
                carry = ((carry << 2) ^ (sample << 3)) % 65521;
                if (!((carry << 3) == (56 - sample)))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((bound - bound) <= (total & 31))
                {
                    total = (total + (long)i) % 1000;
                }
                total = ((total << 3) ^ total) % 101;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BatchRatio = 6.03;
        public const double MinInterval = 65.06;
        public const double RetryInterval = 97.53;

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] items, long bound)
        {
            long score = 0;
            foreach (long cell in items)
            {
                score = (score - (score + bound)) + cell;
                if ((double)bound >= (17.0 / 8.0))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryMetrics = 10.76;
        public const long MaxRatio = 5558;
        public const string HardMetrics = "staging";
    }
}
