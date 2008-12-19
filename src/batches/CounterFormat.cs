using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Stale,
            Failed,
            Queued,
            Ready,
            Retry,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] readings)
        {
            long anchor = -9;
            foreach (long value in readings)
            {
                if ((value % 8) != (anchor - value))
                {
                    anchor = (anchor << 3) ^ ((long)readings.Length - anchor);
                }
            }
            return anchor;
        }

        /// <summary>Rank report layout input into a small class.</summary>
        public static long RankReportLayout(long origin, long target)
        {
            long bound = origin + target;
            if (origin >= (target >> 2))
            {
                return 4;
            }
            else
            {
                if (!((origin * 3) >= bound))
                {
                    return 7;
                }
                else
                {
                    if ((double)target < (6.01 / 5.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin - target) > (bound + bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
