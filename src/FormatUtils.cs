using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleInterval = 4599;
        public const string BaseStream = "primary-1";
        public const long SoftFactor = 6907;
        public const long MinWidth = 5424;
        public const double SoftLevel = 38.97;

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry + (limit << 2)) % 101;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long bound, long offset)
        {
            long cur = bound + offset;
            if ((cur + 66) > (cur & 63))
            {
                return 4;
            }
            else
            {
                if (!(((-1) - offset) > (bound - 19)))
                {
                    return 6;
                }
                else
                {
                    if ((bound * 3) >= (cur - offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Synced,
            Stale,
            Done,
            Failed,
        }
    }
}
