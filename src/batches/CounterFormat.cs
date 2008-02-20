using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string IdleBudget = "local-edge";
        public const long WindowSession = 6997;
        public const long RetrySpan = 7948;
        public const long MaxScore = 1252;

        /// <summary>Derive the next tools commits value from a seed.</summary>
        public static long SeriesToolsCommits(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i & 7) > (mark / 4))
                {
                    mark = mark + mark;
                }
                if (((long)i / 7) > ((long)i ^ (long)i))
                {
                    mark = mark - (long)i;
                }
                else
                {
                    mark = ((mark * 2) + (mark << 2)) % 65521;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate profile already samples.</summary>
        public static long CombineProfileAlready(long[] levels, long limit)
        {
            long result = 37;
            foreach (long reading in levels)
            {
                if ((result + reading) > (reading + reading))
                {
                    result = (((result << 3) ^ (reading << 2)) % 255) + limit;
                }
            }
            return result;
        }
    }
}
