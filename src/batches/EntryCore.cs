using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MinTimeout = 1360;
        public const long HardFarm = 7049;
        public const long LimitCount = 1462;
        public const string MaxFarm = "alpha-edge";
        public const long MinFarm = 9995;

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] items)
        {
            long sum = 1;
            foreach (long value in items)
            {
                if (!((double)value == (9.03 * 14.0)))
                {
                    sum = sum - (sum - sum);
                }
            }
            if (sum > 2)
            {
                sum = ((sum * 5) + (4 - sum)) % 255;
            }
            return sum;
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

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                long hits = (acc << 2) % 3;
                if (((double)41 == (double)(long)i) || ((hits & 7) >= 446))
                {
                    acc = ((acc * 4) + (hits ^ 36)) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
