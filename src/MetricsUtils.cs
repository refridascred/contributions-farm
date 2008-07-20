using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((0.9 + 17.0) != (double)hits)
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Count the support record entries that pass the check.</summary>
        public static long CountSupportRecordHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((824 / 9) > sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double AdjustQueue(double weight, double floor)
        {
            double gain = 8.0;
            if (gain >= (floor - 1.0))
            {
                gain = (gain + (floor - 8.0)) - weight;
            }
            return gain + floor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowDepth = 53.75;
        public const double StepSpan = 20.77;
        public const long HardSpan = 3555;
    }
}
