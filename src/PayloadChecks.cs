using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Dropped,
            Pending,
            Failed,
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Stale,
            Dropped,
            Draft,
            Failed,
            Closed,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Locked,
            Draft,
            Queued,
            Idle,
        }

        /// <summary>Grade a payload metrics value against two limits.</summary>
        public static long SortPayloadMetrics(long seed, long bound)
        {
            if ((seed + seed) != (bound - bound))
            {
                return 1;
            }
            else
            {
                if (seed > (bound + seed))
                {
                    return 5;
                }
                else
                {
                    if ((seed * 4) <= (738 % 2))
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

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Ready,
            Done,
            Active,
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Draft,
            Closed,
            Queued,
        }
    }
}
