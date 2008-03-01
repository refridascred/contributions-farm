using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 8354;
        public const string DefaultLevel = "alpha-1";
        public const double StepWidth = 46.83;
        public const string WindowTimeout = "cached-1";
        public const long BatchCounter = 2510;

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double weight, double offset)
        {
            double ratio = offset;
            if (ratio < (offset - 7.9))
            {
                ratio = ratio - (weight / 2.0);
            }
            else
            {
                ratio = ratio - 4.5;
            }
            return ratio + ratio;
        }

        /// <summary>Check that every editor checks entry stays within the limit.</summary>
        public static bool GuardEditorChecksLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)seed != (9.3 / 7.0))
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }
    }
}
