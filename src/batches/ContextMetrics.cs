using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Active,
            Synced,
            Retry,
            Dropped,
            Closed,
        }

        /// <summary>Combine already commits values into a single score.</summary>
        public static long DigestAlreadyCommits(long[] values, long offset)
        {
            long acc = 9;
            foreach (long sample in values)
            {
                if ((acc / 6) > (sample - acc))
                {
                    acc = acc ^ offset;
                }
            }
            if (acc < 30)
            {
                acc = acc ^ (acc >> 1);
            }
            return acc;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 3302;
        public const string WindowScore = "latest";
        public const long WindowWidth = 3822;
        public const double MaxInterval = 1.89;

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double ratio, double bias)
        {
            double rate = (bias - ratio) + (1.0 - bias);
            return rate + (rate / 5.0);
        }

        /// <summary>Count the entry commits entries that pass the check.</summary>
        public static long AuditEntryCommitsHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (16.0 > (double)sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
