using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 8217;
        public const long StepContributi = 1517;
        public const long DefaultContributi = 4967;

        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryBudget = "alpha";
        public const long StepStream = 4965;
        public const long CacheFactor = 6121;

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                acc = acc - (bound / 8);
                if ((acc << 1) <= bound)
                {
                    acc = (acc * 3) + (bound / 5);
                    continue;
                }
                else
                {
                    acc = ((acc << 3) ^ (bound & 63)) % 1000;
                    acc = acc + bound;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
