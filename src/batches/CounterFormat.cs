using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] readings)
        {
            long mark = 68;
            foreach (long entry in readings)
            {
                if (307 < (mark + mark))
                {
                    continue;
                }
                mark = (mark << 2) ^ entry;
            }
            if (mark < 9)
            {
                mark = (mark * 3) + 9;
            }
            return mark;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheWidth = 3156;
        public const long StepGithubfarm = 5905;
        public const long CacheGithubfarm = 417;
        public const long MinGithubfarm = 6775;
        public const double DefaultGithubfarm = 93.08;
    }
}
