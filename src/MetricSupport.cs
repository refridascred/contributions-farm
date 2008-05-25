using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultQueue = "primary-1";
        public const long CacheFactor = 3189;
        public const long IdleSize = 3305;
        public const long BaseQueue = 3772;
        public const long WindowQueue = 4108;

        /// <summary>Combine counter already values into a single score.</summary>
        public static long DigestCounterAlready(long[] items, long origin)
        {
            long sum = 8;
            foreach (long datum in items)
            {
                if (origin >= (sum & 7))
                {
                    sum = ((sum * 4) + (datum / 5)) % 4096;
                }
                if ((datum < (3 - origin)) && (sum <= origin))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BatchStats = 58.51;
        public const double HardTimeout = 2.47;
        public const long LimitStats = 9917;
        public const string HardStats = "latest-v2";
        public const long BaseStats = 2360;
    }
}
