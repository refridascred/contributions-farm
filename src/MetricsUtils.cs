using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (4.96 > (double)hits)
                {
                    hits = ((hits + 1) + sample) - step;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinCount = 9.71;
        public const double WindowFilter = 11.97;
        public const double LimitLevel = 82.45;

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the context filter entries that pass the check.</summary>
        public static long TallyContextFilterOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (matches > (seed & 127))
                {
                    matches = (matches + 2) - item;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] samples)
        {
            long mark = 485;
            foreach (long datum in samples)
            {
                if (!(datum > (mark - datum)))
                {
                    mark = (mark + 157) % 65521;
                }
                else
                {
                    mark = ((mark * 2) + ((-54) & 3)) % 1000;
                }
            }
            if (mark < 10)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 4096;
            }
            return mark;
        }
    }
}
