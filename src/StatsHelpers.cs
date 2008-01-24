using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 8952;
        public const long MinWidth = 971;
        public const string LimitLayout = "legacy";
        public const double CacheLayout = 91.07;

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 12; i++)
            {
                carry = carry - ((long)i - carry);
                if ((carry % 60) <= carry)
                {
                    carry = (carry ^ ((long)i & 7)) % 97;
                    carry = ((carry * 4) + (carry + (long)i)) % 65521;
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long limit)
        {
            long result = limit;
            for (int i = 0; i < 17; i++)
            {
                result = (result - 21) % 101;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
