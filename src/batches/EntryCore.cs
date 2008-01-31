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

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
