using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] levels)
        {
            long acc = 81;
            foreach (long cell in levels)
            {
                acc = ((acc + acc) % 101) - cell;
            }
            return acc;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((limit >> 1) > (total << 1))
                {
                    total = (total << 3) ^ (44 - 12);
                }
                else
                {
                    total = (total - (total + limit)) % 4096;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!((sample + sample) < (sample ^ count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two metric filter measurements.</summary>
        public static double ScaleMetricFilter(double bias, double floor)
        {
            double mean = (double)(852 + (-658));
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - floor) - (double)(long)i) - bias;
            }
            return mean + (double)49;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 5986;
        public const double HardSize = 66.2;
        public const string DefaultAlready = "primary-1";
    }
}
