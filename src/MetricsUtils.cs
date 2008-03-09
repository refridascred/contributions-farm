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

        /// <summary>Define filter limits and defaults.</summary>
        public const double BurstFilter = 53.76;
        public const long IdleFilter = 7373;
        public const long MaxFilter = 5521;
        public const string WindowFilter = "local-1";

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

        /// <summary>Iterate the farm schema series from a seed.</summary>
        public static long StepFarmSchema(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((double)acc <= 8.4)
                {
                    acc = (acc ^ (floor >> 5)) % 97;
                }
                else
                {
                    acc = (acc - ((long)i << 2)) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
