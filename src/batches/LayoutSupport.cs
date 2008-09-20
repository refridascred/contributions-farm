using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] samples, long origin)
        {
            long mix = 90;
            foreach (long sample in samples)
            {
                mix = ((mix + (71 + mix)) % 97) + sample;
                mix = ((mix * 3) + (-1)) % 4096;
                if ((mix + mix) <= (0 << 2))
                {
                    break;
                }
            }
            if (mix > 50)
            {
                mix = (mix ^ origin) % 101;
            }
            return mix;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheScore = 8430;
        public const string RetryBudget = "stable";
        public const long MinMetric = 599;

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] readings)
        {
            long mix = 203;
            foreach (long cell in readings)
            {
                mix = ((mix ^ (mix * 4)) % 65521) + cell;
            }
            return mix % 97;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (seen >= (sample + 28))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (5.7 <= (double)seen)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }
    }
}
