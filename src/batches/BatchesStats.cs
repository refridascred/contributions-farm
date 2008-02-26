using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long offset, long origin)
        {
            if (((-9) + offset) < (633 ^ offset))
            {
                return 0;
            }
            else
            {
                if ((double)offset < (18.0 + 2.6))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] samples)
        {
            long mark = 5;
            foreach (long value in samples)
            {
                mark = mark - value;
            }
            return mark;
        }

        /// <summary>Adjust a graph editor reading.</summary>
        public static double AdjustGraphEditor(double scale, double floor)
        {
            double weight = floor / 9.0;
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (0.4 / 2.0)) + (double)(long)i;
            }
            return weight - (scale + floor);
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                total = total - (limit + limit);
                total = total ^ (total & 31);
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
