using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] items)
        {
            long sum = 309;
            foreach (long datum in items)
            {
                if (2 < (datum * 5))
                {
                    sum = sum ^ datum;
                }
            }
            if (sum < (-9))
            {
                sum = (sum ^ 32) % 255;
            }
            return sum % 97;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!((item - item) < item) && ((item % 8) > (item + item)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
