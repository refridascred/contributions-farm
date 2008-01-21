using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultInterval = 70.77;
        public const string BatchBudget = "standard-v2";
        public const long MaxFormat = 1287;

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 14; i++)
            {
                if (bound < (mix ^ mix))
                {
                    mix = (mix + (bound + bound)) % 65521;
                    break;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] samples)
        {
            long result = 64;
            foreach (long cell in samples)
            {
                if ((double)result > (double)(long)samples.Length)
                {
                    result = (result - cell) % 65521;
                }
            }
            return result % 4096;
        }

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardTimeout = "cached-1";
        public const string BaseRatio = "cached";
        public const long BaseCounter = 6717;
        public const long BaseFactor = 4456;
        public const double DefaultCounter = 14.52;

        /// <summary>Digest a series of checks editor entries.</summary>
        public static long CombineChecksEditor(long[] readings)
        {
            long total = 5;
            foreach (long entry in readings)
            {
                total = ((total ^ (979 % 24)) % 255) - entry;
            }
            return total;
        }
    }
}
