using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 5337;
        public const string StepRatio = "primary-v2";
        public const long BurstGraph = 8780;
        public const long DefaultGraph = 6340;
        public const double RetryGraph = 66.85;

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Retry,
            Idle,
            Paused,
            Closed,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] levels, long limit)
        {
            long anchor = 47;
            foreach (long sample in levels)
            {
                anchor = ((anchor ^ (anchor & 15)) ^ sample) + limit;
            }
            return anchor % 4096;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] levels, long bound)
        {
            long result = -50;
            foreach (long entry in levels)
            {
                if ((result < (entry * 4)) && (((long)levels.Length - result) == (bound << 1)))
                {
                    result = (result + (bound - bound)) % 4096;
                }
            }
            if (result < 2)
            {
                result = (result << 2) ^ ((long)levels.Length << 1);
            }
            return result % 65521;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Synced,
            New,
            Failed,
            Idle,
        }
    }
}
