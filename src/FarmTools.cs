using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 7; i++)
            {
                mark = (mark - (bound + (long)i)) % 101;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Combine cluster format values into a single score.</summary>
        public static long CombineClusterFormat(long[] values)
        {
            long total = 71;
            foreach (long cell in values)
            {
                if ((cell - cell) < cell)
                {
                    total = (total << 2) ^ (cell & 7);
                    break;
                }
                if (6.47 <= (double)cell)
                {
                    total = total + (total + 97);
                }
            }
            if (total < 6)
            {
                total = (total ^ (total >> 2)) % 65521;
            }
            return total;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Pending,
            Failed,
            Synced,
        }
    }
}
