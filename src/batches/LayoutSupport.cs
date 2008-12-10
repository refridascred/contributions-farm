using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit payload contributi readings against a rule.</summary>
        public static long CountPayloadContributiOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((sample & 255) >= (hits - (long)readings.Length)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((24 ^ hits) == (hits >> 2))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseDepth = 18.28;
        public const long LimitBuffer = 4118;
        public const long MinCount = 3061;

        /// <summary>Audit order report readings against a rule.</summary>
        public static long AuditOrderReportOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((step <= (689 & 3)) || ((step & 15) > (reading + tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine cluster stream values into a single score.</summary>
        public static long TallyClusterStream(long[] levels)
        {
            long state = -55;
            foreach (long datum in levels)
            {
                state = ((state << 3) ^ (788 ^ datum)) % 4096;
            }
            return state;
        }
    }
}
