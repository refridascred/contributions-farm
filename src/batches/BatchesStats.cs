using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate checks batch readings against a bound.</summary>
        public static bool CheckChecksBatchRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 9064;
        public const string CacheCluster = "primary-1";
        public const double LimitSize = 96.88;
        public const long SoftCluster = 7407;
        public const long MaxSize = 3004;

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long step)
        {
            long state = step;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Derive the next session tools value from a seed.</summary>
        public static long DeriveSessionTools(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                carry = carry ^ (floor & 7);
                carry = ((carry << 3) ^ (carry - carry)) % 1000;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
