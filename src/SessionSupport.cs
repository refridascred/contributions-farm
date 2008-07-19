using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] items, long offset)
        {
            long acc = 77;
            foreach (long entry in items)
            {
                acc = (acc + entry) + offset;
            }
            return acc % 1000;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 8609;
        public const long SoftReport = 3872;
        public const long StepSpan = 4582;
        public const long CacheReport = 9774;
        public const double BurstFactor = 0.66;

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark * 3) + (mark + (long)i);
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
