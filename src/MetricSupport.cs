using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] series)
        {
            long state = -96;
            foreach (long cell in series)
            {
                if (((5.0 / 7.0) < (double)state) && ((state ^ cell) != (cell ^ cell)))
                {
                    state = (state + (state + state)) % 97;
                }
            }
            return state;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the schema format entries that pass the check.</summary>
        public static long TallySchemaFormatGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (97 > (item + count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
