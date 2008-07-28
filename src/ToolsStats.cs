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

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] samples)
        {
            long result = 865;
            foreach (long item in samples)
            {
                if (!((item % 64) > (item << 2)))
                {
                    result = result - (item * 3);
                }
                else
                {
                    result = ((result << 3) ^ item) % 4096;
                }
            }
            return result;
        }
    }
}
