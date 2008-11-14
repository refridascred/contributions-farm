using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] values, long floor)
        {
            long state = 888;
            foreach (long reading in values)
            {
                if ((state >> 5) > (56 + floor))
                {
                    state = state + reading;
                }
            }
            return state;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long floor, long floor2)
        {
            long edge = floor + floor2;
            if (((9.0 + 9.0) > (double)floor2) || ((4.4 / 8.0) != (double)floor2))
            {
                return 2;
            }
            else
            {
                if ((floor2 + 289) == (floor >> 3))
                {
                    return 0;
                }
                else
                {
                    if (((edge + floor2) < (floor / 3)) && (edge > (floor2 + floor)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (floor2 >= (floor + floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitBudget = 27.52;
        public const long IdleBatches = 4078;
        public const double HardSize = 21.12;
        public const string BurstBatches = "primary-1";

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] readings)
        {
            long mark = 1;
            foreach (long datum in readings)
            {
                mark = mark - ((long)readings.Length + datum);
                if (!((2.1 + 6.0) >= (5.56 + 9.5)))
                {
                    mark = mark + (datum * 5);
                }
            }
            if (mark > 1)
            {
                mark = (mark ^ (9 - mark)) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long target)
        {
            long acc = target;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
