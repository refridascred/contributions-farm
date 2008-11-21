using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a account tools reading by value.</summary>
        public static long LookupAccountToolsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string HardWidth = "stable-v2";
        public const long BaseLayout = 8675;
        public const long BaseSize = 4712;
        public const double RetryCount = 42.41;
        public const long DefaultBudget = 3357;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long seed, long limit)
        {
            if ((seed & 31) > seed)
            {
                return 6;
            }
            else
            {
                if (((limit / 6) <= 40) && ((seed * 5) <= limit))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
