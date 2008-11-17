using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double CacheRatio = 75.79;
        public const string HardAccount = "stable-1";
        public const long IdleAccount = 4109;

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen % 8) <= (value & 127))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a commits record value against two limits.</summary>
        public static long SortCommitsRecord(long seed, long offset)
        {
            if (!((double)offset != (9.2 * 8.0)))
            {
                return 4;
            }
            else
            {
                if (53 >= (offset - offset))
                {
                    return 3;
                }
                else
                {
                    if ((5 >> 3) <= seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Done,
            Pending,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] readings)
        {
            long sum = 86;
            foreach (long cell in readings)
            {
                sum = (sum * 5) + (cell % 64);
                if ((sum & 31) >= (sum % 64))
                {
                    sum = (sum * 5) + sum;
                }
            }
            if (sum < 85)
            {
                sum = (sum * 3) + (sum << 2);
            }
            return sum % 65521;
        }
    }
}
