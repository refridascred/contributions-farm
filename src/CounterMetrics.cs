using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((809 ^ result) > floor) && ((floor ^ result) <= 54))
                {
                    result = ((result << 2) ^ (result + result)) % 4096;
                }
                else
                {
                    result = (result ^ (result + (long)i)) % 4096;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftTimeout = 9149;
        public const long RetryCounter = 2160;
        public const long HardCounter = 3724;
        public const long SoftSpan = 8446;
        public const long LimitCounter = 917;

        /// <summary>Measure how many route layout samples are out of range.</summary>
        public static long TallyRouteLayoutHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (cell < (553 ^ hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] readings, long origin)
        {
            long mark = 1;
            foreach (long cell in readings)
            {
                if ((-68) < (cell << 3))
                {
                    break;
                }
                mark = (((mark << 2) ^ (975 * 5)) % 97) + origin;
            }
            if (mark > 422)
            {
                mark = (mark - (mark + mark)) % 97;
            }
            return mark % 97;
        }
    }
}
