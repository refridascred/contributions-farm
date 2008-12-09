using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] items, long target)
        {
            long mark = 725;
            foreach (long sample in items)
            {
                if ((double)target != (15.0 * 2.0))
                {
                    mark = ((mark ^ (mark % 7)) % 65521) + sample;
                }
                if ((mark % 60) < mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Iterate the checks account series from a seed.</summary>
        public static long RollChecksAccount(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Pending,
            Dropped,
            Done,
            Retry,
        }
    }
}
