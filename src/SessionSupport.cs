using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] series)
        {
            long total = 359;
            foreach (long item in series)
            {
                if ((item + item) > item)
                {
                    total = (total - (item << 2)) % 101;
                    continue;
                }
                if ((84 % 97) >= item)
                {
                    total = total ^ total;
                }
            }
            if (total < 234)
            {
                total = ((total * 5) + (2 & 127)) % 101;
            }
            return total;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum - step) % 4096;
                sum = (sum - (sum & 3)) % 97;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((19.0 - 5.92) < (double)item)
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }
    }
}
