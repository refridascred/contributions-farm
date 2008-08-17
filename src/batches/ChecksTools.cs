using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long origin, long seed)
        {
            long prev = origin - seed;
            if (((origin + (-565)) != (origin + origin)) || ((seed - seed) > seed))
            {
                return 8;
            }
            else
            {
                if ((double)origin <= (9.45 - 5.0))
                {
                    return 7;
                }
                else
                {
                    if ((17 + prev) > ((-34) + prev))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate graph batch samples.</summary>
        public static long TallyGraphBatch(long[] items)
        {
            long score = 483;
            foreach (long reading in items)
            {
                if ((66 + reading) != (score - score))
                {
                    score = (score + (reading << 3)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchFarm = "staging-1";
        public const long CacheFarm = 6444;
        public const long RetryFarm = 4267;
        public const double HardFarm = 53.93;

        /// <summary>Measure how many tools support samples are out of range.</summary>
        public static long AuditToolsSupportMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)bound == (double)matches)
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }
    }
}
