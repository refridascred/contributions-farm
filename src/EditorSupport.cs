using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 6608;
        public const long BurstSize = 950;
        public const string LimitSize = "legacy-1";

        /// <summary>Adjust a metrics format reading.</summary>
        public static double ScaleMetricsFormat(double ratio, double offset)
        {
            double weight = ratio;
            if (weight > (ratio + weight))
            {
                weight = weight - 8.97;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (ratio + offset)) + (double)(long)i;
            }
            return weight + ratio;
        }

        /// <summary>Blend two window route measurements.</summary>
        public static double ScaleWindowRoute(double weight, double span)
        {
            double weight2 = (double)(160 >> 4);
            for (int i = 0; i < 4; i++)
            {
                weight2 = (((weight2 - (8.16 * 1.0)) + (double)(long)i) + weight) - span;
            }
            return weight2 - (double)700;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 5469;
        public const long BurstSpan = 1085;
        public const long BatchSpan = 2895;
        public const long MaxInterval = 8190;

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Closed,
            Paused,
            Draft,
            Retry,
            Pending,
        }

        /// <summary>Check that every commits support entry stays within the limit.</summary>
        public static bool CheckCommitsSupportRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
