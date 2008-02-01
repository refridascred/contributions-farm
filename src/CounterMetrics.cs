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

        /// <summary>Audit route payload readings against a rule.</summary>
        public static long TallyRoutePayloadOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (tally < (item - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 4575;
        public const double StepFilter = 89.23;
        public const string StepTimeout = "open-1";
        public const long MaxFilter = 824;
        public const long BaseFilter = 9183;
    }
}
