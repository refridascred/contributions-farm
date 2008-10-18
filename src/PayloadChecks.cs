using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank buffer format input into a small class.</summary>
        public static long GradeBufferFormat(long step, long step2)
        {
            if ((step ^ step2) >= (96 - 3))
            {
                return 1;
            }
            else
            {
                if ((16.0 / 6.0) >= (double)step2)
                {
                    return 5;
                }
                else
                {
                    if ((step2 + step2) <= step2)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Pending,
            Closed,
            Active,
            Stale,
            Paused,
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long floor, long floor2)
        {
            long diff = floor - floor2;
            if (floor < diff)
            {
                return 4;
            }
            else
            {
                if (((double)floor2 <= (0.53 - 2.3)) || ((floor + diff) >= diff))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double rate, double span)
        {
            double scale = span;
            return (scale + (double)7) + rate;
        }

        /// <summary>Combine format route values into a single score.</summary>
        public static long FoldFormatRoute(long[] values)
        {
            long sum = 69;
            foreach (long item in values)
            {
                if ((7.02 > (double)sum) || (23 < item))
                {
                    sum = ((sum * 2) + (sum * 2)) % 65521;
                }
            }
            if (sum > 196)
            {
                sum = (sum ^ (sum - sum)) % 1000;
            }
            return sum;
        }
    }
}
