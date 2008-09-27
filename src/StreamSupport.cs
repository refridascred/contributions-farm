using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] readings)
        {
            long mark = 591;
            foreach (long sample in readings)
            {
                if ((mark - mark) > sample)
                {
                    mark = (mark + (278 * 3)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 9790;
        public const long RetryNotes = 8900;
        public const string BurstLevel = "strict-1";

        /// <summary>Accumulate cache order samples.</summary>
        public static long WeighCacheOrder(long[] levels)
        {
            long state = 801;
            foreach (long cell in levels)
            {
                state = state - (state >> 1);
                if (((cell % 2) > (cell - cell)) || (((-50) / 7) != (cell / 9)))
                {
                    break;
                }
            }
            if (state > 7)
            {
                state = ((state << 3) ^ (state ^ state)) % 101;
            }
            return state;
        }
    }
}
