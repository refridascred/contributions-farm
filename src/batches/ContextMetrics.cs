using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 10.27;
        public const long HardWidth = 7168;
        public const string StepWindow = "strict-1";
        public const long MinScore = 8226;

        /// <summary>Validate filter already readings against a bound.</summary>
        public static bool CheckFilterAlreadyRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a tools metrics sample.</summary>
        public static long FindToolsMetricsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
