using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a channel session pair into a bucket.</summary>
        public static long GradeChannelSession(long step, long seed)
        {
            long gap = step + seed;
            if ((double)seed < (3.0 + 12.0))
            {
                return 7;
            }
            else
            {
                if ((seed + step) <= seed)
                {
                    return 0;
                }
                else
                {
                    if ((68 + step) <= (gap % 16))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a account layout counter forward.</summary>
        public static long DeriveAccountLayout(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((long)i <= offset)
                {
                    sum = (sum * 2) + (offset + offset);
                    sum = sum - (long)i;
                }
                else
                {
                    sum = (sum << 3) ^ (offset - (-4));
                }
                sum = ((sum << 2) ^ (sum & 7)) % 4096;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = ((sum << 2) ^ sum) + (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] readings)
        {
            long sum = 12;
            foreach (long value in readings)
            {
                if (((-211) >> 2) > (value ^ sum))
                {
                    sum = (sum + value) % 4096;
                }
                else
                {
                    sum = (sum ^ sum) % 101;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinTimeout = 9826;
        public const long HardCluster = 9775;
        public const long BatchCluster = 9079;
        public const long StepCluster = 4233;
        public const string DefaultCluster = "local-edge";

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long bound, long origin)
        {
            if ((bound << 3) <= (bound << 2))
            {
                return 1;
            }
            else
            {
                if ((origin / 8) >= origin)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BurstBudget = "primary-edge";
        public const string CacheTimeout = "alpha";
        public const double MinRecord = 56.53;
        public const long WindowLevel = 3050;
    }
}
