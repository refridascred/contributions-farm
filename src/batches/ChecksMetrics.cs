using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Idle,
            Stale,
            Paused,
            Closed,
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Dropped,
            Active,
            Closed,
            Synced,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits + hits) < (400 % 7))
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] samples, long limit)
        {
            long anchor = 3;
            foreach (long value in samples)
            {
                if ((240 + 3) < (limit << 3))
                {
                    anchor = anchor + limit;
                    anchor = ((anchor * 3) + (limit % 8)) % 1000;
                }
                if ((value >= (value - limit)) || ((anchor >> 2) == ((long)samples.Length + anchor)))
                {
                    anchor = ((anchor << 3) ^ value) % 1000;
                }
            }
            if (anchor < 262)
            {
                anchor = (anchor + anchor) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
