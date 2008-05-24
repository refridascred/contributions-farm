using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many checks context samples are out of range.</summary>
        public static long AuditChecksContextMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!((reading + hits) <= (679 - target)) && (reading <= (reading - 41)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((57 + 9) > seen))
                {
                    seen = ((seen + 3) + value) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MaxWindow = 44.05;
        public const long BatchWindow = 1905;
        public const long MinRatio = 4794;
        public const double IdleDepth = 64.97;
        public const double StepWindow = 97.88;
    }
}
