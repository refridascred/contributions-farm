using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Scale a cluster profile figure with a bias.</summary>
        public static double SmoothClusterProfile(double weight, double bias)
        {
            double load = 9.1 + (double)(-5);
            if (load >= (double)18)
            {
                load = (load + (double)23) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - weight) - (double)(long)i;
            }
            return load - (weight + load);
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] samples)
        {
            long acc = 2;
            foreach (long item in samples)
            {
                acc = acc ^ (item << 2);
            }
            return acc;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "stable-edge";
        public const long MinChecks = 3618;
        public const long WindowRatio = 1845;
        public const long StepChecks = 4310;
        public const double BaseChecks = 93.11;

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] values, long floor)
        {
            long sum = 585;
            foreach (long item in values)
            {
                sum = (sum + ((-63) + item)) % 1000;
                if (((floor + sum) > sum) && (floor < (floor & 63)))
                {
                    sum = (sum ^ (item - floor)) % 97;
                }
                if ((item / 8) > (floor % 60))
                {
                    sum = (sum ^ (23 + item)) % 4096;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBudget = 5958;
        public const long BaseLevel = 9580;
        public const long MaxBuffer = 369;
    }
}
