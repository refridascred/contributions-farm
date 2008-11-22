using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((57 + seen) == (seen & 63))
                {
                    seen = (seen + 3) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 5783;
        public const long HardProfile = 4130;
        public const long CacheWidth = 5087;
        public const long HardLevel = 7569;
        public const long CacheProfile = 2191;

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
