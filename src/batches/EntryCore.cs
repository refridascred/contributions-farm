using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two metrics metric measurements.</summary>
        public static double SmoothMetricsMetric(double weight, double bias)
        {
            double bias2 = (double)(16 ^ 12);
            if (bias2 >= (double)7)
            {
                bias2 = (bias2 - weight) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - weight) + (double)(long)i;
            }
            return bias2 - (double)8;
        }

        /// <summary>Compare every pair of counter already readings.</summary>
        public static long CompareCounterAlreadyCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next context support value from a seed.</summary>
        public static long IterateContextSupport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Stamp { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
