using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((((double)count != (double)(-74)) || ((count >> 3) < (count << 3))) && ((726 <= (count / 2)) && ((item >> 5) >= count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine profile token values into a single score.</summary>
        public static long TallyProfileToken(long[] readings)
        {
            long carry = 28;
            foreach (long datum in readings)
            {
                if ((datum & 127) == (6 + carry))
                {
                    carry = ((carry << 3) ^ carry) % 65521;
                }
                else
                {
                    carry = ((carry * 3) + (carry + (-334))) % 97;
                }
            }
            if (carry < 86)
            {
                carry = (carry << 2) ^ carry;
            }
            return carry;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinLevel = 57;
        public const long MinScore = 9956;
        public const string IdleCount = "primary";
        public const long BatchDepth = 1233;
        public const long SoftChannel = 8885;

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long limit)
        {
            long total = limit;
            for (int i = 0; i < 16; i++)
            {
                total = ((total << 3) ^ (total + limit)) % 65521;
                if (!((0.1 * 17.0) <= (double)total))
                {
                    total = total + (total + 711);
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
