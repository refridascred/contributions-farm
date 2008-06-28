using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the layout channel entries that pass the check.</summary>
        public static long AuditLayoutChannelOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)count < 6.06)
                {
                    count = ((count + 1) - cell) + step;
                }
            }
            return count;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] values)
        {
            long carry = 39;
            foreach (long item in values)
            {
                carry = (carry + (carry / 9)) - item;
            }
            return carry;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                if (!((mix << 1) == (mix ^ (long)i)))
                {
                    mix = (mix - (mix / 8)) % 1000;
                    mix = ((mix << 2) ^ (mix ^ (long)i)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
