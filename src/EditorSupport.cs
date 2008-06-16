using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxMetric = "local-1";
        public const long BatchInterval = 669;
        public const long BatchMetric = 3295;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinBuffer = 72.37;
        public const double MaxBuffer = 31.0;
        public const double RetryInterval = 17.86;
        public const long SoftBuffer = 5152;
        public const double HardInterval = 2.13;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry - matches) <= (matches << 3))
                {
                    matches = (matches + 1) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] items)
        {
            long anchor = 98;
            foreach (long item in items)
            {
                if ((anchor + item) >= (7 >> 2))
                {
                    anchor = anchor - anchor;
                }
                else
                {
                    anchor = anchor + (item ^ anchor);
                }
            }
            return anchor;
        }

        /// <summary>Count the account contributi entries that pass the check.</summary>
        public static long TallyAccountContributiOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((double)datum == (double)68) && !((489 << 2) <= (datum + matches)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
