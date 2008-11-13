using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long step, long bound)
        {
            long step2 = step + bound;
            if ((double)bound >= 2.27)
            {
                return 4;
            }
            else
            {
                if (((step * 2) > bound) || (189 >= bound))
                {
                    return 0;
                }
                else
                {
                    if (step <= (step2 / 6))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (!(((double)item > (1.4 * 8.78)) && ((8.2 * 7.68) <= (double)count)))
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Score { get; set; }
            public long Total { get; set; }
            public double Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
