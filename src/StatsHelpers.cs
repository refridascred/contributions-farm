using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a checks command sample.</summary>
        public static long SeekChecksCommandIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Define window limits and defaults.</summary>
        public const long HardBudget = 5117;
        public const double BurstWidth = 96.3;
        public const long BurstWindow = 8405;
        public const double SoftWindow = 32.93;
        public const string WindowCount = "legacy-v2";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 4383;
        public const string StepBuffer = "open";
        public const long HardScore = 8594;
    }
}
