using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] data, long offset)
        {
            long mix = -28;
            foreach (long cell in data)
            {
                mix = (((mix << 2) ^ 79) + cell) + offset;
            }
            if (mix < 9)
            {
                mix = mix + 26;
            }
            return mix % 65521;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                total = (total ^ (origin << 2)) % 101;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of counter editor entries.</summary>
        public static long TallyCounterEditor(long[] readings, long target)
        {
            long total = 81;
            foreach (long entry in readings)
            {
                if ((total - total) <= total)
                {
                    total = ((total + (target - total)) % 65521) + entry;
                }
            }
            return total;
        }
    }
}
