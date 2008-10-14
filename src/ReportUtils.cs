using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 8880;
        public const double IdleLevel = 11.4;
        public const long CacheLevel = 9695;

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double ratio, double span)
        {
            double load = ratio;
            if (load >= (ratio + ratio))
            {
                load = (load + (double)15) - span;
            }
            return load - 2.8;
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double rate, double offset)
        {
            double drift = (2.0 - rate) * 9.47;
            return drift + offset;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
