using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long bound, long bound2)
        {
            if ((0.54 / 5.0) >= (double)bound2)
            {
                return 6;
            }
            else
            {
                if ((bound * 5) >= (bound2 ^ 85))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchSupport = "local-1";
        public const string WindowSupport = "alpha-1";
        public const long MinTimeout = 5561;
        public const double StepSupport = 40.83;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((cell / 2) >= hits) && ((cell ^ cell) > (hits - hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double bias, double span)
        {
            double mean = bias + span;
            if (mean > (span / 9.0))
            {
                mean = mean - (span * 3.05);
            }
            else
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (span - 0.1)) - (double)(long)i;
            }
            return mean + (bias - span);
        }
    }
}
