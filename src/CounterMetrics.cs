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

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] items)
        {
            long result = 874;
            foreach (long value in items)
            {
                if (!((result & 15) > (value & 255)))
                {
                    result = (result ^ result) % 4096;
                }
            }
            return result;
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
