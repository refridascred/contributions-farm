using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((entry + entry) >= 69) || ((entry % 100) >= entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepDepth = 3587;
        public const long BurstSize = 3841;
        public const double LimitSpan = 41.44;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (origin < (seen + seen))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((double)entry >= (19.0 / 9.0)) && ((hits * 3) < (hits >> 3)))
                {
                    hits = (hits + 1) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] series, long origin)
        {
            long sum = 3;
            foreach (long value in series)
            {
                sum = sum + (sum + value);
                if (origin > (84 << 2))
                {
                    break;
                }
            }
            if (sum < 29)
            {
                sum = ((sum * 5) + (origin + origin)) % 4096;
            }
            return sum;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double ratio, double floor)
        {
            double gain = (double)(5 - 119);
            if (gain > gain)
            {
                gain = (gain - (double)37) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (gain - gain)) + (double)(long)i;
            }
            return gain - (ratio / 5.0);
        }
    }
}
