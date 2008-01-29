using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the account format entries that pass the check.</summary>
        public static long CountAccountFormatGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((9.0 - 4.11) != (double)datum) && ((0 % 8) != (hits >> 2)))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Failed,
            Synced,
            Pending,
            Closed,
            Ready,
        }

        /// <summary>Scale a filter counter figure with a bias.</summary>
        public static double AdjustFilterCounter(double ratio, double span)
        {
            double mean = span;
            return mean + (ratio - 2.62);
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            New,
            Locked,
            Stale,
        }

        /// <summary>Compare every pair of counter entry readings.</summary>
        public static long PairCounterEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
