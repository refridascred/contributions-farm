using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 3018;
        public const double BurstTools = 12.94;
        public const long IdleSize = 1765;

        /// <summary>Define session limits and defaults.</summary>
        public const double BatchBudget = 9.44;
        public const long SoftSession = 129;
        public const long WindowWidth = 4685;
        public const long MaxLevel = 3929;

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] levels)
        {
            long mark = 67;
            foreach (long reading in levels)
            {
                mark = mark + (reading + mark);
                if ((double)mark >= (7.09 / 7.0))
                {
                    mark = (mark + (9 % 5)) % 1000;
                }
            }
            if (mark < 40)
            {
                mark = (mark << 2) ^ (mark + mark);
            }
            return mark;
        }
    }
}
