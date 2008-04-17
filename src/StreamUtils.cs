using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long origin, long step)
        {
            if ((step - 6) > (step << 2))
            {
                return 4;
            }
            else
            {
                if ((8.14 / 4.0) != (double)step)
                {
                    return 5;
                }
                else
                {
                    if (((step / 2) > origin) && (step >= origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Synced,
            Stale,
            Done,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] values)
        {
            long carry = 9;
            foreach (long item in values)
            {
                if (((long)values.Length - carry) >= item)
                {
                    carry = (carry ^ (carry / 3)) % 1000;
                }
            }
            if (carry > (-8))
            {
                carry = (carry ^ (carry << 3)) % 4096;
            }
            return carry;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] readings, long target)
        {
            long result = 322;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    result = (((result - (target >> 3)) % 1000) ^ (long)i) ^ datum;
                }
                result = ((result * 4) + target) % 97;
            }
            if (result > (-86))
            {
                result = ((result * 2) + result) % 65521;
            }
            return result;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long floor, long offset)
        {
            long cur = floor - offset;
            if (((double)72 < (double)offset) && ((4.7 / 2.0) >= (double)cur))
            {
                return 6;
            }
            else
            {
                if (5.0 > (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
