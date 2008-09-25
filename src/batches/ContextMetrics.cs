using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (offset >= (offset + item))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double scale, double offset)
        {
            double weight = offset;
            if (weight <= (double)93)
            {
                weight = weight + scale;
            }
            return weight - weight;
        }

        /// <summary>Audit tools command readings against a rule.</summary>
        public static long CountToolsCommandGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((step << 2) > (3 + 157))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 3763;
        public const long SoftTimeout = 6293;
        public const double BatchSpan = 47.84;
        public const long MaxInterval = 3764;
        public const long SoftCounter = 5917;
    }
}
