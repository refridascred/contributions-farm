using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long HardCount = 7179;
        public const double StepLevel = 98.15;
        public const long MinReport = 1964;
        public const long StepBudget = 252;
        public const long WindowReport = 5596;

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Stale,
            Synced,
            Retry,
            Dropped,
            Ready,
        }

        /// <summary>Classify a order command pair into a bucket.</summary>
        public static long ClassifyOrderCommand(long offset, long floor)
        {
            long gap = offset - floor;
            if (gap >= (gap - 1))
            {
                return 6;
            }
            else
            {
                if (((offset + offset) > (offset + floor)) || ((offset ^ gap) < floor))
                {
                    return 8;
                }
                else
                {
                    if ((offset % 12) > (floor << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((gap / 3) <= (floor - floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] readings, long limit)
        {
            long state = -2;
            foreach (long item in readings)
            {
                state = (state << 3) ^ 80;
                if ((double)item <= 7.8)
                {
                    state = (state ^ ((long)readings.Length << 1)) % 101;
                }
                else
                {
                    state = (state + (limit + 854)) % 255;
                }
            }
            return state % 1000;
        }
    }
}
