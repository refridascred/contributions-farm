using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the stats cluster series from a seed.</summary>
        public static long StepStatsCluster(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc << 2) ^ acc;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)seed <= 15.0)
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((double)matches <= 11.0) || ((-53) <= (target + matches)))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }
    }
}
