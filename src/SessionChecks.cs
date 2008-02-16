using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] values, long offset)
        {
            long total = 456;
            foreach (long reading in values)
            {
                if ((total << 1) <= (reading << 1))
                {
                    total = (total ^ reading) % 4096;
                }
                total = total - (offset >> 2);
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBuffer = "strict-edge";
        public const string LimitCount = "legacy-1";
        public const string MinBuffer = "alpha-edge";

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Owner { get; set; }
            public bool Level { get; set; }
            public long Score { get; set; }
        }
    }
}
