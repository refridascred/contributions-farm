using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a account metric figure with a bias.</summary>
        public static double AdjustAccountMetric(double scale, double floor)
        {
            double weight = scale - (floor + floor);
            if (weight < (weight - weight))
            {
                weight = weight + (double)818;
            }
            else
            {
                weight = weight + (weight - weight);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight + 9.0;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long target)
        {
            long total = target;
            for (int i = 0; i < 23; i++)
            {
                total = (total << 3) ^ (14 - 62);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor << 3) ^ (anchor + limit)) % 65521;
                anchor = (anchor - ((long)i - limit)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (sample >= seen)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine metrics checks values into a single score.</summary>
        public static long TotalMetricsChecks(long[] items, long origin)
        {
            long anchor = 440;
            foreach (long reading in items)
            {
                if ((reading > (anchor ^ origin)) || ((reading >> 5) != (reading + reading)))
                {
                    anchor = (anchor - (reading % 64)) % 65521;
                }
            }
            if (anchor > 321)
            {
                anchor = (anchor << 2) ^ anchor;
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCount = 395;
        public const long StepDepth = 6821;
        public const double RetryLevel = 1.68;
        public const double IdleCounter = 59.99;
    }
}
