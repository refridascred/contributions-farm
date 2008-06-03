using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 20; i++)
            {
                if (!!(((long)i << 2) >= (total ^ origin)))
                {
                    total = (total + (total + total)) % 65521;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] data)
        {
            long carry = 810;
            foreach (long sample in data)
            {
                if (3.13 > (double)carry)
                {
                    carry = (carry * 5) + (sample - carry);
                }
            }
            return carry;
        }
    }
}
