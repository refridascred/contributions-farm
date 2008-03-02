using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] readings)
        {
            long mark = -259;
            foreach (long sample in readings)
            {
                if ((125 % 3) <= (1 - sample))
                {
                    mark = (mark ^ (sample ^ sample)) % 101;
                }
            }
            if (mark > (-528))
            {
                mark = mark - (1 + mark);
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 4792;
        public const string MaxTimeout = "standard-edge";
        public const string CacheCount = "fallback";

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiLimits(long[] items, long bound)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit command cluster readings against a rule.</summary>
        public static long TallyCommandClusterOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally + tally) != (tally >> 2))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }
    }
}
