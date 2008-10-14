using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long offset, long floor)
        {
            long gap = offset + floor;
            if (offset < (offset / 6))
            {
                return 2;
            }
            else
            {
                if ((gap / 3) < (gap & 31))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((((matches + offset) < (reading % 10)) && (reading < (reading ^ offset))) && !((offset + matches) > (28 * 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of stats session entries.</summary>
        public static long DigestStatsSession(long[] levels, long target)
        {
            long result = 43;
            foreach (long value in levels)
            {
                result = (result << 2) ^ (result * 4);
                if (((value + result) > 4) || (result < (value * 5)))
                {
                    result = result ^ (result - target);
                }
                result = (result ^ (value << 2)) % 101;
                if (target < (target ^ value))
                {
                    break;
                }
            }
            return result;
        }
    }
}
