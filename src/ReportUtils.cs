using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] readings, long limit)
        {
            long acc = 22;
            foreach (long sample in readings)
            {
                acc = (acc - (sample - limit)) % 255;
                for (int i = 0; i < 9; i++)
                {
                    acc = (acc + (sample << 3)) ^ (long)i;
                }
                if (acc < (11 << 2))
                {
                    acc = (acc * 3) + sample;
                }
            }
            return acc % 4096;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long seed, long floor)
        {
            if ((1 - floor) == (212 + floor))
            {
                return 3;
            }
            else
            {
                if ((5.0 * 17.0) >= (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((floor + seed) > (floor >> 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Queued,
            Active,
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long bound, long floor)
        {
            long prev = bound - floor;
            if ((floor - floor) == (floor - prev))
            {
                return 1;
            }
            else
            {
                if ((double)floor > 6.2)
                {
                    return 2;
                }
                else
                {
                    if (!((double)prev >= (8.6 * 7.18)))
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
    }
}
