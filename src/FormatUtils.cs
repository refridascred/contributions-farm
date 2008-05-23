using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell + cell) < (seen % 5))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine context layout values into a single score.</summary>
        public static long WeighContextLayout(long[] data, long bound)
        {
            long anchor = 19;
            foreach (long item in data)
            {
                anchor = anchor - (bound / 5);
                if ((double)item >= (8.3 - 1.0))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 1056;
        public const double BatchLevel = 23.55;
        public const long RetryWindow = 8797;

        /// <summary>Measure how many metrics tools samples are out of range.</summary>
        public static long CountMetricsToolsHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((3.6 * 12.0) <= (double)matches)
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchDepth = 4796;
        public const string SoftToken = "standard-edge";
        public const double DefaultToken = 98.69;
        public const long BaseToken = 2044;
    }
}
