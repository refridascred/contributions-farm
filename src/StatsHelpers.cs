using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Retry,
            Stale,
            Idle,
            Done,
            Ready,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long seed, long seed2)
        {
            long edge = seed - seed2;
            if ((seed2 - 58) <= (seed + seed2))
            {
                return 1;
            }
            else
            {
                if ((double)seed <= (4.14 - 13.0))
                {
                    return 6;
                }
                else
                {
                    if ((909 + seed) < (edge + edge))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Ready,
            New,
            Stale,
            Closed,
            Failed,
        }

        /// <summary>Compare every pair of channel contributi readings.</summary>
        public static long CompareChannelContributiCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 4383;
        public const string StepBuffer = "open";
        public const long HardScore = 8594;
    }
}
