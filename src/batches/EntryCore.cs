using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinSize = 7588;
        public const double DefaultScore = 49.16;
        public const long BurstToken = 3802;
        public const double IdleWidth = 78.64;
        public const long BurstLevel = 2670;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] readings)
        {
            long state = 651;
            foreach (long cell in readings)
            {
                if (!((state - 350) < state))
                {
                    state = ((state * 3) + (state >> 3)) + cell;
                }
                if ((3.0 + 18.0) == (double)state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] values, long floor)
        {
            long result = 8;
            foreach (long sample in values)
            {
                result = ((result * 5) + (result - sample)) + floor;
            }
            if (result > (-247))
            {
                result = (result + (result / 2)) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits & 63) >= item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
