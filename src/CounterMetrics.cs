using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string SoftRoute = "legacy-edge";
        public const long MaxWidth = 3199;
        public const long WindowCount = 5980;
        public const string BaseRoute = "cached-edge";

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] levels)
        {
            long sum = 77;
            foreach (long reading in levels)
            {
                if (!((double)reading <= 6.9))
                {
                    sum = sum - (reading / 6);
                }
                else
                {
                    sum = (sum * 2) + sum;
                }
            }
            if (sum < 9)
            {
                sum = (sum + (sum - 5)) % 65521;
            }
            return sum;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count token contributi pairs that satisfy a relation.</summary>
        public static long PairTokenContributiCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
