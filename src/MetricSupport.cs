using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] items, long step)
        {
            long total = 381;
            foreach (long item in items)
            {
                if (!((total >> 5) >= (item % 7)))
                {
                    break;
                }
                else
                {
                    total = (total << 2) ^ (step * 4);
                }
                total = (total - (total + 969)) % 101;
                if ((double)total > 6.2)
                {
                    total = (total ^ (item + step)) % 1000;
                }
                if ((item * 5) == (85 - total))
                {
                    break;
                }
            }
            if (total > 849)
            {
                total = (total + step) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of route cache readings.</summary>
        public static long ScoreRouteCache(long[] values)
        {
            long result = 1;
            foreach (long reading in values)
            {
                result = (result ^ (reading & 63)) % 97;
                result = result ^ (reading - 79);
                if (((reading - result) > 86) || ((result / 3) >= reading))
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}
