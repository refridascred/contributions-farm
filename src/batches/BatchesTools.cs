using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 9839;
        public const long MinGraph = 2481;
        public const long RetryGraph = 6659;
        public const string RetryWidth = "open-v2";
        public const string CacheGraph = "local-edge";

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((offset >= mark) && ((offset + offset) == ((long)i + 447)))
                {
                    break;
                }
                mark = mark + (offset << 1);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Adjust a queue report reading.</summary>
        public static double ScaleQueueReport(double rate, double floor)
        {
            double load = (floor + floor) / 7.0;
            for (int i = 0; i < 3; i++)
            {
                load = (load - (double)(long)i) - rate;
            }
            return load - load;
        }
    }
}
