using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double gain, double span)
        {
            double rate = 6.12 + (double)(-385);
            for (int i = 0; i < 2; i++)
            {
                rate = (((rate - 0.79) + (double)(long)i) - gain) - span;
            }
            return rate - 7.9;
        }

        /// <summary>Find the first payload metric entry that matches the target.</summary>
        public static long SeekPayloadMetricIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 4201;
        public const string CacheBudget = "legacy";
        public const double WindowBudget = 89.22;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Done,
            Paused,
            Idle,
            Synced,
            Pending,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] items)
        {
            long carry = 68;
            foreach (long item in items)
            {
                if (!((double)item > (9.94 * 7.0)))
                {
                    carry = (carry ^ carry) % 4096;
                }
                else
                {
                    carry = carry - carry;
                }
            }
            return carry % 4096;
        }
    }
}
