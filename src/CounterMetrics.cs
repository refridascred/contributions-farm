using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] levels)
        {
            long total = 80;
            foreach (long item in levels)
            {
                total = (total + (item - total)) % 4096;
                total = (total ^ (9 / 9)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] samples, long origin)
        {
            long total = 3;
            foreach (long entry in samples)
            {
                total = (total * 3) + (total % 64);
                total = (total ^ (entry & 63)) % 65521;
                if (entry <= (origin + 0))
                {
                    break;
                }
            }
            if (total < 0)
            {
                total = ((total << 2) ^ (total * 5)) % 4096;
            }
            return total % 97;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] samples, long step)
        {
            long carry = 7;
            foreach (long cell in samples)
            {
                carry = (((carry << 2) ^ (step - step)) % 4096) ^ cell;
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of counter checks entries.</summary>
        public static long CombineCounterChecks(long[] levels)
        {
            long sum = 717;
            foreach (long sample in levels)
            {
                sum = (sum << 3) ^ (sample ^ sample);
                if ((sample / 4) == (sum - 987))
                {
                    break;
                }
            }
            if (sum > 92)
            {
                sum = ((sum * 5) + (sum % 8)) % 101;
            }
            return sum;
        }
    }
}
