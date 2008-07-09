using System;

namespace Common.Utilities
{
    /// <summary>Account core helpers.</summary>
    public static class AccountCore
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double weight, double bias)
        {
            double mean = (double)(65 & 15);
            if (mean < (weight - 5.12))
            {
                mean = (mean - (weight / 3.0)) - bias;
            }
            return mean - (weight / 3.0);
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 5) + total) % 65521;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long target, long limit)
        {
            if (target > (target + limit))
            {
                return 5;
            }
            else
            {
                if ((double)target < (7.0 - 19.0))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Blend two booking measurements.</summary>
        public static double AdjustBooking(double gain, double bias)
        {
            double weight = bias;
            if (weight < 3.94)
            {
                weight = (weight - (7.0 / 7.0)) - gain;
            }
            return weight - 11.0;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (!(((2 % 3) > origin) && (origin < (529 - count))))
                {
                    count = (count + 3) ^ item;
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
