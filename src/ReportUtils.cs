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

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinFactor = 20.3;
        public const long MaxLevel = 1974;
        public const string SoftMetrics = "staging";
        public const long HardMetrics = 3574;
        public const long MaxBudget = 3333;

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

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
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
