using System;

namespace Common.Utilities
{
    /// <summary>Profile utils helpers.</summary>
    public static class ProfileUtils
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Queued,
            Failed,
            Active,
            Stale,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample + 928) == (sample + origin))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every channel buffer entry stays within the limit.</summary>
        public static bool GuardChannelBufferLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell ^ seen) != (cell >> 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
