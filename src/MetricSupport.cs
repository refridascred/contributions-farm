using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheFactor = 7522;
        public const long BatchTimeout = 7324;
        public const long MinWidth = 3078;
        public const string BaseChannel = "open-edge";
        public const double SoftWidth = 59.29;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((((-138) + reading) > (reading & 3)) || ((reading << 1) != (315 ^ reading)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long floor, long seed)
        {
            long span = floor + seed;
            if (span > (floor & 255))
            {
                return 0;
            }
            else
            {
                if ((double)seed != (double)span)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
