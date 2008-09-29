using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxSize = 457;
        public const long CacheFilter = 8887;
        public const long SoftFilter = 8174;
        public const long BurstFilter = 8049;

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Paused,
            Ready,
            Synced,
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit tools metrics readings against a rule.</summary>
        public static long AuditToolsMetricsHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits << 2) > (104 / 2))
                {
                    hits = (hits + 2) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (908 >= (datum ^ datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long limit, long origin)
        {
            long slot = limit + origin;
            if ((origin + slot) < (slot - slot))
            {
                return 6;
            }
            else
            {
                if ((slot - (-8)) < (slot >> 3))
                {
                    return 5;
                }
                else
                {
                    if (limit < slot)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
