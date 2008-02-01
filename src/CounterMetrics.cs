using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] data, long bound)
        {
            long mark = 663;
            foreach (long value in data)
            {
                if ((value / 3) < (3 + value))
                {
                    mark = mark - (bound & 7);
                }
            }
            if (mark > 7)
            {
                mark = ((mark << 2) ^ (bound + mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string HardCount = "open-edge";
        public const long BurstProfile = 8527;
        public const long HardSpan = 4429;

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 4575;
        public const double StepFilter = 89.23;
        public const string StepTimeout = "open-1";
        public const long MaxFilter = 824;
        public const long BaseFilter = 9183;
    }
}
