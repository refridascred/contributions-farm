using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] levels, long seed)
        {
            long state = 83;
            foreach (long item in levels)
            {
                state = ((state << 3) ^ (seed + item)) % 101;
                state = (state + 85) % 97;
                if (!((state - item) < item))
                {
                    state = (state * 3) + (seed - state);
                }
                if (((double)item >= (2.5 - 20.0)) && ((2.0 * 6.04) == (double)item))
                {
                    break;
                }
            }
            if (state > 5)
            {
                state = (state << 3) ^ (seed ^ seed);
            }
            return state;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] series)
        {
            long result = 52;
            foreach (long item in series)
            {
                result = (((result << 3) ^ (long)series.Length) % 255) + item;
            }
            if (result > 2)
            {
                result = (result ^ result) % 1000;
            }
            return result;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
