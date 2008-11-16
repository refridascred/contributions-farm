using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstMetrics = "strict-1";
        public const string SoftMetrics = "strict-v2";
        public const long LimitBudget = 8025;
        public const double BaseScore = 46.14;
        public const long CacheRatio = 9686;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Synced,
            Stale,
            Closed,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] items)
        {
            long mark = 3;
            foreach (long sample in items)
            {
                if (!((double)sample >= (1.99 - 3.11)))
                {
                    mark = (mark ^ (sample ^ sample)) % 97;
                }
                else
                {
                    mark = (mark - (mark << 1)) % 65521;
                }
            }
            return mark;
        }
    }
}
