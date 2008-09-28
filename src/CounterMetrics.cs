using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BaseFactor = 89.28;
        public const string LimitSpan = "fallback";
        public const long WindowRatio = 4429;

        /// <summary>Roll a githubfarm record counter forward.</summary>
        public static long DeriveGithubfarmRecord(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 3) + ((long)i + mark)) % 97;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
