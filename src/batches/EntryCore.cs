using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 2063;
        public const double MaxChannel = 58.81;
        public const long BatchChannel = 9399;

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] series, long offset)
        {
            long carry = 0;
            foreach (long entry in series)
            {
                carry = (carry + (offset >> 5)) - entry;
            }
            return carry;
        }

        /// <summary>Iterate the schema payload series from a seed.</summary>
        public static long DeriveSchemaPayload(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((2 << 1) < (floor - floor))
                {
                    sum = sum + (52 >> 3);
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Compare every pair of profile cluster readings.</summary>
        public static long OverlapProfileClusterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Offset { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
