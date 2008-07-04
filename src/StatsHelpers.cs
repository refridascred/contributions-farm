using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Ready,
            Retry,
            Pending,
            Closed,
        }

        /// <summary>Match up queue window samples.</summary>
        public static long MatchQueueWindowCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxWidth = 5313;
        public const string DefaultBuffer = "local-v2";
        public const long HardBuffer = 7585;
        public const double MaxDepth = 55.4;

        /// <summary>Define farm limits and defaults.</summary>
        public const double HardFarm = 14.75;
        public const double MaxFarm = 85.21;
        public const double LimitWidth = 23.47;

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
