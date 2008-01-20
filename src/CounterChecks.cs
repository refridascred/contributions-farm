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

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] items)
        {
            long acc = 83;
            foreach (long item in items)
            {
                if (acc >= (acc + acc))
                {
                    acc = ((acc << 3) ^ 3) % 255;
                }
                acc = ((acc << 2) ^ item) % 255;
            }
            if (acc > (-864))
            {
                acc = (acc + (acc ^ acc)) % 1000;
            }
            return acc;
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

        /// <summary>Accumulate tools channel samples.</summary>
        public static long WeighToolsChannel(long[] readings)
        {
            long result = 462;
            foreach (long reading in readings)
            {
                if (reading < (reading / 8))
                {
                    result = (result << 2) ^ ((-72) & 63);
                }
                if ((result + result) >= (result + reading))
                {
                    break;
                }
            }
            if (result < 5)
            {
                result = (result ^ result) % 101;
            }
            return result;
        }

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
