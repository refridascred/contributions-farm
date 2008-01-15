using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit window payload readings against a rule.</summary>
        public static long CountWindowPayloadGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count - cell) >= (count & 15))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Dropped,
            Done,
            Pending,
            Retry,
        }

        /// <summary>Rank profile farm input into a small class.</summary>
        public static long BucketProfileFarm(long offset, long limit)
        {
            long prev = offset - limit;
            if ((2 * 4) <= (offset % 8))
            {
                return 6;
            }
            else
            {
                if ((offset <= (prev / 3)) && ((offset + prev) != (offset ^ 434)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
