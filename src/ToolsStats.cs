using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            New,
            Locked,
            Pending,
            Active,
            Paused,
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Pending,
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 797;
        public const long IdleWidth = 9492;
        public const long BurstSchema = 4348;

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
