using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count context metric pairs that satisfy a relation.</summary>
        public static long CompareContextMetricCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum << 2) ^ sum) % 65521;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
