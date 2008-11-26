using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Closed,
            Dropped,
            New,
            Pending,
            Queued,
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Dropped,
            Retry,
            New,
            Paused,
            Ready,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 8901;
        public const long DefaultProfile = 4950;
        public const long WindowProfile = 7205;
        public const long CacheProfile = 9934;
        public const string BaseBudget = "latest";

        /// <summary>Match up report command samples.</summary>
        public static long OverlapReportCommandCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] items)
        {
            long score = -24;
            foreach (long value in items)
            {
                score = (score ^ (value / 5)) % 101;
                if (!((score << 3) <= (value + score)))
                {
                    score = (score - (score >> 1)) % 101;
                }
            }
            return score;
        }
    }
}
