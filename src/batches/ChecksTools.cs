using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate already order samples.</summary>
        public static long CombineAlreadyOrder(long[] series, long bound)
        {
            long score = 81;
            foreach (long cell in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = ((((score * 2) + (0 >> 5)) % 255) - (long)i) - cell;
                }
                if ((double)bound <= (double)(long)series.Length)
                {
                    score = ((score * 3) + (score + 2)) % 101;
                }
            }
            return score;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches + matches) >= matches)
                {
                    matches = ((matches + 1) ^ entry) + origin;
                }
            }
            return matches;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
