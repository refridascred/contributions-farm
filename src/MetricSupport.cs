using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultFormat = 85.98;
        public const long BatchBudget = 1734;
        public const long BatchFormat = 5335;
        public const long MinFormat = 7695;
        public const long MaxFormat = 2615;

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
