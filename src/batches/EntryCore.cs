using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseScore = 2523;
        public const double IdleTimeout = 38.14;
        public const long RetryRoute = 9073;

        /// <summary>Validate graph cluster readings against a bound.</summary>
        public static bool ValidateGraphClusterRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public double Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of order profile readings.</summary>
        public static long DigestOrderProfile(long[] samples)
        {
            long total = 14;
            foreach (long cell in samples)
            {
                total = (total << 2) ^ (2 + cell);
            }
            if (total < 404)
            {
                total = ((total * 3) + total) % 255;
            }
            return total % 1000;
        }
    }
}
