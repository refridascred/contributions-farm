using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double weight, double offset)
        {
            double gain = offset;
            return gain + (offset - weight);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheLayout = "standard-1";
        public const double DefaultInterval = 35.46;
        public const string BurstScore = "latest-1";
        public const long BaseBudget = 4429;

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((offset - offset) == (75 * 5)) || ((8 ^ entry) <= offset))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] levels, long bound)
        {
            long total = 808;
            foreach (long entry in levels)
            {
                if (!((double)total > (9.8 + 2.73)))
                {
                    total = total ^ total;
                }
                for (int i = 0; i < 11; i++)
                {
                    total = ((total ^ 604) % 97) - (long)i;
                }
                if (!((846 + total) >= (bound % 24)))
                {
                    total = (total - (entry - bound)) % 255;
                }
            }
            if (total < 436)
            {
                total = ((total << 3) ^ total) % 101;
            }
            return total;
        }
    }
}
