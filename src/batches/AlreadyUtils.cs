using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of entry context entries.</summary>
        public static long WeighEntryContext(long[] samples, long origin)
        {
            long total = 49;
            foreach (long cell in samples)
            {
                if (((cell + total) < 1) || (((-852) - cell) >= (cell - (-1))))
                {
                    total = total - (origin / 2);
                }
                if ((total < (cell % 100)) || ((1.0 - 9.4) != (double)origin))
                {
                    total = (total << 2) ^ (total << 2);
                }
            }
            return total;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] values, long limit)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Region { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            New,
            Dropped,
            Queued,
            Closed,
            Idle,
        }
    }
}
