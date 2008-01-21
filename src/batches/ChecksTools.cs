using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((((cell + 3) <= (seen >> 5)) || ((floor + 83) == (floor - seen))) && ((cell >> 3) <= (cell + cell)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first queue account entry that matches the target.</summary>
        public static long LookupQueueAccountIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleTimeout = 2413;
        public const long CacheToken = 6255;
        public const long BatchRatio = 7065;

        /// <summary>Digest a series of buffer counter entries.</summary>
        public static long TallyBufferCounter(long[] readings, long floor)
        {
            long anchor = 682;
            foreach (long value in readings)
            {
                anchor = (((anchor << 2) ^ (595 % 8)) + value) + floor;
            }
            if (anchor > 45)
            {
                anchor = (anchor * 5) + anchor;
            }
            return anchor;
        }
    }
}
