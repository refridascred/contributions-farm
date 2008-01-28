using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((1.6 * 15.0) < (double)(long)i)
                {
                    result = ((result << 3) ^ 81) % 97;
                    result = (result ^ seed) % 255;
                    break;
                }
                result = (result ^ (seed + result)) % 4096;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleFactor = 9343;
        public const long CacheDepth = 8064;
        public const long SoftInterval = 1751;
        public const long BaseCommits = 1692;

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Ratio { get; set; } = "";
            public bool Owner { get; set; }
            public bool Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long step, long origin)
        {
            if ((((-24) * 5) != (84 + step)) || (step < (origin - step)))
            {
                return 6;
            }
            else
            {
                if (origin < (origin & 127))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Derive the next cluster context value from a seed.</summary>
        public static long SeriesClusterContext(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
