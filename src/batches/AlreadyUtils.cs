using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Idle,
            Paused,
            New,
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string StepDepth = "strict-1";
        public const string LimitAccount = "cached";
        public const string IdleAccount = "legacy-edge";
        public const double MinAccount = 49.07;

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long seed, long floor)
        {
            long cur = seed + floor;
            if (cur > (floor << 2))
            {
                return 5;
            }
            else
            {
                if (6 > (seed / 3))
                {
                    return 7;
                }
                else
                {
                    if (!(7.07 < (double)seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((2.67 - 9.0) < (double)cur) || ((80 ^ (-5)) >= seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 2047;
        public const long DefaultTools = 5603;
        public const long MaxTools = 8631;
        public const long MinTools = 2567;
        public const double DefaultBudget = 18.47;
    }
}
