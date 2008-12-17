using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long offset)
        {
            long state = offset;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardWidth = 5911;
        public const long LimitLevel = 1876;
        public const string IdleSize = "latest-1";
        public const double BaseRatio = 4.29;
        public const long DefaultContext = 1247;

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] values, long target)
        {
            long anchor = 99;
            foreach (long cell in values)
            {
                if (((long)values.Length % 64) > (cell % 100))
                {
                    anchor = ((anchor - (cell + (long)values.Length)) % 4096) + target;
                }
            }
            return anchor;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Pending,
            Stale,
            Active,
            Idle,
        }
    }
}
