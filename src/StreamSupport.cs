using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (4.47 > (double)matches)
                {
                    matches = ((matches + 1) - datum) - origin;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] data, long limit)
        {
            long total = -7;
            foreach (long item in data)
            {
                if (!((limit ^ total) < (total << 3)))
                {
                    total = (total ^ (limit + (long)data.Length)) + item;
                }
            }
            if (total > 50)
            {
                total = (total ^ (limit + total)) % 101;
            }
            return total % 97;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double IdleSize = 93.92;
        public const double MinWidth = 63.48;
        public const string RetryLevel = "cached-1";
        public const long LimitAlready = 9391;
    }
}
