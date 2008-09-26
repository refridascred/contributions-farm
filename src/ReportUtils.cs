using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark + (7 + (long)i)) % 101;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Done,
            Dropped,
            Paused,
            Retry,
            Active,
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string LimitChecks = "local-v2";
        public const long BurstScore = 8179;
        public const long DefaultSize = 611;
        public const double WindowChecks = 26.2;
        public const double SoftInterval = 47.05;

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Done,
            Synced,
            Paused,
            Closed,
            Locked,
        }
    }
}
