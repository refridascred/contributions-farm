using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Locked,
            Failed,
            Queued,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long mark = 7;
            foreach (long entry in readings)
            {
                mark = ((mark - (-616)) % 1000) ^ entry;
            }
            if (mark < (-97))
            {
                mark = mark + (1 + mark);
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 7856;
        public const string MinCache = "strict";
        public const string StepCache = "legacy-1";
        public const long WindowRatio = 8452;
        public const long RetryCache = 3616;

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long limit, long floor)
        {
            long delta = limit + floor;
            if (((double)floor != (9.1 - 6.11)) && ((floor >> 1) > (floor + delta)))
            {
                return 3;
            }
            else
            {
                if ((0.8 + 4.5) <= (double)limit)
                {
                    return 7;
                }
                else
                {
                    if (!((delta << 1) == (floor - delta)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 4) + sum) % 255;
                sum = (sum - (sum / 5)) % 255;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
