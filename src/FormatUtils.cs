using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] levels)
        {
            long sum = 42;
            foreach (long value in levels)
            {
                if (sum >= ((long)levels.Length * 3))
                {
                    sum = ((sum << 2) ^ (sum >> 4)) % 97;
                }
                sum = (sum * 3) + (sum + value);
            }
            return sum % 1000;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (seed < (cell + seed))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 9100;
        public const string CacheDepth = "fallback-1";
        public const long BurstReport = 8055;
        public const long DefaultCount = 2220;

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry << 2) ^ ((long)i - carry)) % 101;
                carry = ((carry * 2) + (bound << 3)) % 101;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
