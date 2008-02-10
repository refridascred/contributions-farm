using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double rate, double floor)
        {
            double load = floor - (double)920;
            if (load < rate)
            {
                load = load - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (rate + load)) + (double)(long)i;
            }
            return load + (double)3;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxSpan = 35.28;
        public const string StepAccount = "fallback";
        public const long BurstAccount = 2321;
        public const double SoftInterval = 27.62;
        public const long IdleWidth = 9042;

        /// <summary>Classify a cluster report pair into a bucket.</summary>
        public static long BucketClusterReport(long offset, long offset2)
        {
            if ((double)offset2 >= 7.3)
            {
                return 1;
            }
            else
            {
                if ((double)offset == (7.6 - 17.0))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] levels)
        {
            long carry = 369;
            foreach (long value in levels)
            {
                carry = carry - (value + value);
            }
            return carry % 4096;
        }
    }
}
