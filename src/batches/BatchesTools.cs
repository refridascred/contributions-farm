using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((double)346 >= (double)matches))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long seed, long offset)
        {
            long slot = seed - offset;
            if ((seed + 4) != (227 * 2))
            {
                return 4;
            }
            else
            {
                if ((95 ^ 90) == (slot + 37))
                {
                    return 6;
                }
                else
                {
                    if ((double)seed <= 5.5)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
