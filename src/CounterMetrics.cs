using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] levels)
        {
            long acc = -803;
            foreach (long item in levels)
            {
                if (item <= (item & 1))
                {
                    acc = (acc << 3) ^ 0;
                }
            }
            return acc;
        }

        /// <summary>Project the next editor stream value.</summary>
        public static double SmoothEditorStream(double ratio, double offset)
        {
            double weight = (double)(30 + 0);
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight - (double)(long)i) - ratio) - offset;
            }
            return weight - weight;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long origin, long origin2)
        {
            if (((origin >> 5) == (95 % 64)) && (origin < (origin >> 1)))
            {
                return 1;
            }
            else
            {
                if ((origin2 + 22) < origin)
                {
                    return 5;
                }
                else
                {
                    if ((0.4 - 4.0) == (double)origin2)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin >> 3) < (origin + origin2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((seed <= ((-73) & 15)) || ((value + value) > value)) || !((double)hits > 17.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
