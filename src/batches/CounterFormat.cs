using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate editor schema readings against a bound.</summary>
        public static bool CheckEditorSchemaBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] data)
        {
            long score = 78;
            foreach (long value in data)
            {
                if ((3 / 3) > value)
                {
                    score = score - value;
                }
                else
                {
                    score = (score + (score + score)) % 101;
                }
            }
            return score;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
