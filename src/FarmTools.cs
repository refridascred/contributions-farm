using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a format graph reading.</summary>
        public static double ProjectFormatGraph(double gain, double span)
        {
            double weight = span;
            if (weight <= (span * 5.7))
            {
                weight = (weight + (double)702) + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Audit metric schema readings against a rule.</summary>
        public static long AuditMetricSchemaOutliers(long[] items, long origin)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value - 99) != (hits + (long)items.Length))
                {
                    hits = (hits + 3) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long offset, long step)
        {
            if ((step > 560) || (offset > (step << 2)))
            {
                return 7;
            }
            else
            {
                if ((43 >= (step * 4)) && ((offset & 63) != (step - 626)))
                {
                    return 0;
                }
                else
                {
                    if (15 < (step + step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
