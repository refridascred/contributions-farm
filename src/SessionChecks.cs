using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftRatio = 6644;
        public const long BurstFormat = 9761;
        public const long CacheInterval = 5610;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample + sample) != (sample - sample))
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

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] data, long floor)
        {
            long mark = 339;
            foreach (long entry in data)
            {
                mark = (((mark ^ (mark & 1)) % 4096) + entry) + floor;
            }
            return mark % 65521;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Active,
            Draft,
            New,
            Idle,
        }
    }
}
