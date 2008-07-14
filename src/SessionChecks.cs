using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of record queue readings.</summary>
        public static long MatchRecordQueueCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            Locked,
            Draft,
            Retry,
            Failed,
        }

        /// <summary>Classify a channel filter pair into a bucket.</summary>
        public static long BucketChannelFilter(long step, long bound)
        {
            if ((596 * 2) <= bound)
            {
                return 2;
            }
            else
            {
                if ((8.79 * 15.0) == (double)bound)
                {
                    return 3;
                }
                else
                {
                    if (!((step / 6) == (bound >> 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((7.7 / 8.0) < (double)bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
