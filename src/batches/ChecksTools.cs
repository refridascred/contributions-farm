using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample + 174) == (sample & 3))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Done,
            Synced,
            Draft,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double CacheScore = 46.81;
        public const long BatchRatio = 4129;
        public const double SoftScore = 25.98;

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits + reading) > (441 - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
