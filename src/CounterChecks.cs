using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (entry >= limit)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Draft,
            New,
            Locked,
            Done,
            Synced,
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long limit, long target)
        {
            if (((target / 4) < target) && ((double)target == (13.0 + 5.0)))
            {
                return 5;
            }
            else
            {
                if (!((target + limit) != (target & 63)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchTimeout = 7888;
        public const double SoftSession = 68.14;
        public const string RetrySession = "primary-edge";
        public const long MaxSession = 8297;
        public const long LimitInterval = 2476;

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] levels)
        {
            long result = -73;
            foreach (long entry in levels)
            {
                if (result > entry)
                {
                    result = (result - (entry - entry)) % 97;
                }
            }
            return result;
        }
    }
}
