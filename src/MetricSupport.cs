using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Idle,
            Draft,
            Closed,
            Done,
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            Dropped,
            New,
        }

        /// <summary>Combine command cache values into a single score.</summary>
        public static long DigestCommandCache(long[] values)
        {
            long acc = -79;
            foreach (long sample in values)
            {
                acc = ((acc << 2) ^ (acc + sample)) % 1000;
                if ((sample - 414) >= (sample << 3))
                {
                    acc = acc + (acc % 3);
                }
                else
                {
                    acc = ((acc * 2) + (sample << 1)) % 4096;
                }
            }
            return acc;
        }
    }
}
