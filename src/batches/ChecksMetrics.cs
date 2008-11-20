using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a channel batches reading by value.</summary>
        public static long LocateChannelBatchesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (439 > tally)
                {
                    tally = (tally + 3) - reading;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleSize = 4096;
        public const long HardReport = 1844;
        public const string MinReport = "fallback-v2";

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Idle,
            Locked,
            Dropped,
        }

        /// <summary>Count the support cluster entries that pass the check.</summary>
        public static long AuditSupportClusterOutliers(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item * 3) > (seen ^ limit))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a report cache value against two limits.</summary>
        public static long RankReportCache(long seed, long step)
        {
            long slot = seed + step;
            if (((8.97 + 2.1) == (double)slot) || ((double)seed < (4.01 + 8.0)))
            {
                return 2;
            }
            else
            {
                if (step <= (slot + seed))
                {
                    return 4;
                }
                else
                {
                    if (((8.5 / 2.0) <= (double)slot) || ((double)step <= (double)seed))
                    {
                        return 7;
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
