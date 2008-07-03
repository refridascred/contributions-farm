using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Retry,
            Pending,
            Ready,
            New,
            Active,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((((2.57 * 6.14) < (double)seen) && ((636 & 63) <= seen)) || (((long)items.Length & 255) <= (item / 3)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = total + 887;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
