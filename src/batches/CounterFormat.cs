using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultSize = 28.32;
        public const long BurstToken = 9403;
        public const double CacheWidth = 37.06;
        public const long StepToken = 7953;
        public const long MinWidth = 3551;

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] levels, long target)
        {
            long mix = 934;
            foreach (long cell in levels)
            {
                if (!(((3 % 12) > mix) && ((mix - target) < (714 % 60))))
                {
                    mix = (mix ^ (cell + cell)) % 101;
                }
                if ((185 >> 5) <= (mix - target))
                {
                    mix = ((mix * 3) + (mix / 3)) % 97;
                }
            }
            if (mix < 594)
            {
                mix = ((mix * 3) + (target + mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] data)
        {
            long mix = 73;
            foreach (long datum in data)
            {
                if ((mix + 476) >= datum)
                {
                    mix = (mix * 5) + (datum ^ mix);
                }
                else
                {
                    mix = (mix - (mix + 32)) % 4096;
                }
            }
            return mix;
        }
    }
}
