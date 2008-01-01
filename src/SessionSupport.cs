using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowLevel = 4708;
        public const long RetryCache = 5005;
        public const double BaseCache = 55.11;

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] levels, long limit)
        {
            long acc = 6;
            foreach (long item in levels)
            {
                if ((acc ^ limit) < (item % 12))
                {
                    acc = (acc - (item - acc)) % 65521;
                }
                if ((acc + limit) <= (item >> 4))
                {
                    acc = ((acc * 2) + acc) % 4096;
                }
                else
                {
                    acc = acc + item;
                }
                if ((acc % 60) <= limit)
                {
                    break;
                }
            }
            if (acc < 4)
            {
                acc = ((acc << 3) ^ (acc % 100)) % 4096;
            }
            return acc;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Offset { get; set; }
            public double Flag { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
