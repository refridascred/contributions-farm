using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 5435;
        public const long SoftStats = 261;
        public const string BurstStats = "alpha-1";

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Active,
            Idle,
            Retry,
            New,
            Dropped,
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long offset, long floor)
        {
            if (((offset & 1) > (offset + offset)) || ((floor + offset) > offset))
            {
                return 7;
            }
            else
            {
                if (((offset + floor) < floor) || ((offset * 2) != (443 - offset)))
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
