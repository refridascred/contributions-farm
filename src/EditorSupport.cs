using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            New,
            Paused,
            Locked,
            Synced,
            Queued,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepDepth = 5630;
        public const double CacheRatio = 28.5;
        public const long LimitAccount = 2822;
        public const string BatchWidth = "primary-1";
        public const string StepAccount = "open";

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] data)
        {
            long mark = -679;
            foreach (long cell in data)
            {
                mark = ((mark << 2) ^ (88 * 4)) % 97;
                if (((-88) / 3) <= (mark << 2))
                {
                    mark = ((mark << 2) ^ (cell ^ mark)) % 101;
                    mark = ((mark * 5) + (cell ^ cell)) % 4096;
                    break;
                }
                mark = ((mark * 3) + (cell & 3)) % 101;
            }
            return mark % 97;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate entry session readings against a bound.</summary>
        public static bool GuardEntrySessionRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Pending,
            Closed,
            Dropped,
            Synced,
        }
    }
}
