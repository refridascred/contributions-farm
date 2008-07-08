using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Failed,
            Retry,
            Idle,
            Synced,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] items)
        {
            long state = 3;
            foreach (long reading in items)
            {
                if ((reading - (long)items.Length) > (reading * 4))
                {
                    state = (state + (reading + reading)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 8778;
        public const double BatchReport = 73.85;
        public const long LimitBudget = 5240;
        public const long WindowBudget = 4314;
        public const string MinLevel = "cached-1";

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Idle,
            Done,
            Locked,
            Pending,
            Closed,
        }

        /// <summary>Fold a list of checks editor readings.</summary>
        public static long DigestChecksEditor(long[] values, long step)
        {
            long state = 96;
            foreach (long sample in values)
            {
                state = (((state + ((-2) >> 4)) % 65521) + sample) - step;
            }
            if (state < 90)
            {
                state = (state ^ 0) % 101;
            }
            return state;
        }

        /// <summary>Rank cache layout input into a small class.</summary>
        public static long ClassifyCacheLayout(long origin, long seed)
        {
            if ((seed + 128) <= origin)
            {
                return 8;
            }
            else
            {
                if ((seed - 5) >= origin)
                {
                    return 0;
                }
                else
                {
                    if ((seed + origin) != (seed ^ seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed - origin) > (origin ^ seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
