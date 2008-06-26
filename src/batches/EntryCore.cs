using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long target)
        {
            long carry = target;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Adjust a filter window reading.</summary>
        public static double ScaleFilterWindow(double bias, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + (3.8 + offset)) - (double)(long)i) - bias;
            }
            return rate - 4.0;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryRatio = 8198;
        public const long CacheWidth = 5956;
        public const string IdleQueue = "local";

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] data)
        {
            long total = 2;
            foreach (long datum in data)
            {
                if ((datum + 971) < (total + datum))
                {
                    total = (total - (total * 5)) % 65521;
                    total = (total ^ datum) % 97;
                }
                total = (total ^ total) % 1000;
                total = (total + (-327)) % 4096;
            }
            if (total > (-16))
            {
                total = ((total << 3) ^ (total + (long)data.Length)) % 101;
            }
            return total;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
