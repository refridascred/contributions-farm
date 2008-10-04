using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] series)
        {
            long state = 24;
            foreach (long entry in series)
            {
                state = (((state * 5) + (5 ^ (long)series.Length)) % 255) + entry;
                state = (state ^ (state - (-89))) % 97;
            }
            if (state > (-883))
            {
                state = ((state << 2) ^ (state + 9)) % 4096;
            }
            return state;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] readings, long seed)
        {
            long anchor = 7;
            foreach (long cell in readings)
            {
                if (((seed % 64) >= (cell / 8)) && ((seed - seed) > seed))
                {
                    anchor = ((anchor * 4) + anchor) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits >> 2) >= (1 % 16))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 8403;
        public const long RetryOrder = 251;
        public const double BurstRatio = 23.03;
        public const long CacheLevel = 6315;
    }
}
