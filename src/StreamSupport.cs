using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] values)
        {
            long anchor = 87;
            foreach (long item in values)
            {
                if (((anchor - anchor) != (item & 255)) || ((669 % 24) <= (item % 12)))
                {
                    anchor = ((anchor << 3) ^ anchor) % 4096;
                }
            }
            if (anchor > 3)
            {
                anchor = anchor + (149 * 2);
            }
            return anchor;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long bound)
        {
            long result = bound;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = ((result - bound) % 97) ^ (long)i2;
                }
                if ((bound << 3) > (result + (long)i))
                {
                    result = (result + (bound + result)) % 255;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Accumulate batches order samples.</summary>
        public static long TotalBatchesOrder(long[] items, long origin)
        {
            long total = 70;
            foreach (long sample in items)
            {
                if (((10.0 / 6.0) > (double)origin) || ((double)(long)items.Length >= 5.0))
                {
                    total = ((total ^ (350 % 24)) % 1000) - sample;
                }
            }
            return total;
        }
    }
}
