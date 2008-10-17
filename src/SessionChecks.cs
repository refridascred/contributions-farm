using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string SoftOrder = "local-v2";
        public const long CacheOrder = 8253;
        public const long DefaultOrder = 3534;
        public const long CacheInterval = 1784;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)bound == (9.9 - 0.5))
                {
                    count = (count + 3) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally * 4) > 1)
                {
                    tally = (tally + 3) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long seed, long bound)
        {
            if ((bound % 10) <= (bound % 16))
            {
                return 2;
            }
            else
            {
                if ((double)bound > (9.37 / 4.0))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
