using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Failed,
            Idle,
            Dropped,
            Synced,
            Active,
        }

        /// <summary>Grade a report cluster value against two limits.</summary>
        public static long ClassifyReportCluster(long limit, long origin)
        {
            if ((2 >= (limit >> 1)) || (limit >= (origin << 3)))
            {
                return 1;
            }
            else
            {
                if (!((origin + limit) > (limit + origin)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
