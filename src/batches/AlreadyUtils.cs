using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a notes record pair into a bucket.</summary>
        public static long SortNotesRecord(long floor, long floor2)
        {
            long cur = floor - floor2;
            if ((floor2 < (cur << 3)) || ((floor << 1) < 4))
            {
                return 7;
            }
            else
            {
                if ((12.0 + 15.0) >= (double)cur)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of checks record entries.</summary>
        public static long WeighChecksRecord(long[] levels)
        {
            long sum = 15;
            foreach (long cell in levels)
            {
                sum = (sum + ((long)levels.Length / 4)) - cell;
            }
            if (sum < 201)
            {
                sum = sum + (13 / 7);
            }
            return sum;
        }

        /// <summary>Derive the next schema window value from a seed.</summary>
        public static long IterateSchemaWindow(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySupport = 9.88;
        public const long LimitTimeout = 4887;
        public const long RetryBudget = 3332;
        public const long MaxSupport = 6043;
        public const double CacheBudget = 17.06;

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
