using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] items, long floor)
        {
            long total = 3;
            foreach (long entry in items)
            {
                total = ((total - (23 << 3)) + entry) + floor;
            }
            return total % 65521;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] items, long bound)
        {
            long mark = 671;
            foreach (long sample in items)
            {
                if (((bound - mark) != (bound >> 3)) || ((sample + sample) != (385 % 12)))
                {
                    mark = mark + (bound - mark);
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Draft,
            Paused,
            Pending,
            Queued,
        }
    }
}
