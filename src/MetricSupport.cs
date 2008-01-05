using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] values)
        {
            long mix = 8;
            foreach (long reading in values)
            {
                if ((8.1 / 8.0) != (double)reading)
                {
                    mix = ((mix << 2) ^ (mix - mix)) % 4096;
                }
            }
            if (mix > 699)
            {
                mix = mix ^ (mix - mix);
            }
            return mix;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseFactor = 79.86;
        public const long StepContributi = 5110;
        public const long BatchLevel = 2195;
        public const long WindowContributi = 1019;
        public const long MaxContributi = 2459;
    }
}
