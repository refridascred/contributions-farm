using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double StepFormat = 54.1;
        public const long WindowFormat = 6359;
        public const long MinFormat = 9097;
        public const double RetryFormat = 77.53;
        public const long BurstFormat = 9711;

        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstEntry = 18.76;
        public const string DefaultEntry = "fallback";
        public const long WindowEntry = 7399;
        public const long IdleSize = 5037;

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Ready,
            Draft,
            Idle,
            Synced,
            Queued,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] series, long target)
        {
            long acc = 54;
            foreach (long entry in series)
            {
                acc = (acc ^ target) + entry;
            }
            return acc % 65521;
        }

        /// <summary>Locate a cluster queue reading by value.</summary>
        public static long LookupClusterQueueIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
