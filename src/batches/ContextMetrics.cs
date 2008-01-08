using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Measure how many counter profile samples are out of range.</summary>
        public static long AuditCounterProfileMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry / 9) > (0 + entry))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((origin + mix) < mix)
                {
                    continue;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Failed,
            Retry,
            Synced,
            Draft,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((long)readings.Length - entry) <= (entry + entry))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
