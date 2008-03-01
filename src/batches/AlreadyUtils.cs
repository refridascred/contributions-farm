using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of format counter readings.</summary>
        public static long CompareFormatCounterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] series, long seed)
        {
            long state = 8;
            foreach (long entry in series)
            {
                if (!((entry + state) < seed))
                {
                    state = state - (seed % 100);
                    break;
                }
                if ((seed + state) > entry)
                {
                    state = (state ^ (seed % 3)) % 97;
                }
                else
                {
                    state = (state ^ state) % 97;
                }
            }
            return state;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Ready,
            Idle,
            Dropped,
            Closed,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] readings)
        {
            long mark = 671;
            foreach (long reading in readings)
            {
                long offset = (long)readings.Length;
                mark = ((mark * 5) + (offset - mark)) ^ reading;
                if ((mark ^ mark) > (mark * 4))
                {
                    mark = ((mark << 2) ^ (mark << 2)) % 65521;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitTimeout = 72.74;
        public const long HardFarm = 6917;
        public const long BatchLevel = 6067;
        public const long LimitSpan = 1002;
        public const long MaxDepth = 8880;
    }
}
