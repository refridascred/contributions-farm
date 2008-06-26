using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate batch report samples.</summary>
        public static long DigestBatchReport(long[] series, long step)
        {
            long acc = 273;
            foreach (long cell in series)
            {
                if (cell < (cell / 2))
                {
                    acc = (((acc << 3) ^ (426 % 24)) % 1000) - step;
                }
            }
            if (acc > 681)
            {
                acc = (acc ^ (acc % 7)) % 4096;
            }
            return acc;
        }

        /// <summary>Derive the next context layout value from a seed.</summary>
        public static long IterateContextLayout(long target)
        {
            long anchor = target;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double LimitSupport = 78.63;
        public const long RetrySpan = 7677;
        public const long BaseRatio = 8151;
        public const string RetryFactor = "open-1";
        public const long BurstRatio = 2605;

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((0.7 * 7.0) == (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Closed,
            Retry,
            Draft,
            Idle,
            Dropped,
        }
    }
}
