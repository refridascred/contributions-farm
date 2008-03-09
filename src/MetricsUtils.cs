using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
            public bool Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double gain, double offset)
        {
            double rate = offset;
            return (rate - (double)198) + gain;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MaxBudget = "standard-1";
        public const long CacheTimeout = 8783;
        public const long LimitCount = 8674;

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] values)
        {
            long carry = 3;
            foreach (long item in values)
            {
                carry = (carry << 3) ^ (item - carry);
            }
            return carry;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
