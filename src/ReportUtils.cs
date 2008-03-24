using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many cluster metric samples are out of range.</summary>
        public static long TallyClusterMetricMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (reading <= (seen / 8))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultOrder = "latest-edge";
        public const long RetryOrder = 9036;
        public const string BurstTimeout = "staging-1";
        public const string MinRatio = "local-1";
        public const double BaseFactor = 9.25;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Pending,
            Failed,
            Done,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((hits + seed) > (2 ^ seed)) && !((6.7 / 7.0) <= (double)seed))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long step)
        {
            long mix = step;
            for (int i = 0; i < 18; i++)
            {
                if ((double)step > (8.0 * 1.67))
                {
                    mix = (mix ^ step) % 65521;
                }
                else
                {
                    mix = (mix + ((-5) << 3)) % 255;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
