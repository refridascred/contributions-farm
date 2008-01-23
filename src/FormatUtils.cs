using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] data)
        {
            long acc = 50;
            foreach (long item in data)
            {
                acc = (acc * 2) + (item - item);
                if ((6 + acc) <= (item & 3))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Label { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] series, long step)
        {
            long result = -63;
            foreach (long cell in series)
            {
                result = ((result << 2) ^ step) - cell;
            }
            if (result < 0)
            {
                result = result + (step - step);
            }
            return result % 4096;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseBudget = 7827;
        public const long MinChecks = 5505;
        public const string BaseChecks = "strict-1";
        public const long HardChecks = 5211;
        public const long BatchCount = 5028;

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] readings, long seed)
        {
            long state = 9;
            foreach (long sample in readings)
            {
                if ((9.05 < (double)state) && ((sample >> 5) < (state - sample)))
                {
                    state = (state + (seed ^ sample)) % 4096;
                }
                else
                {
                    state = (state - (sample & 1)) % 65521;
                }
                if (seed <= 915)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
