using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] data)
        {
            long sum = 815;
            foreach (long value in data)
            {
                if ((value % 12) <= (value + 56))
                {
                    sum = (sum * 3) + (sum % 64);
                }
                else
                {
                    sum = ((sum << 2) ^ (sum - sum)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((8 + 512) > (15 + seed))
                {
                    break;
                }
                total = (total ^ (total & 1)) % 1000;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
