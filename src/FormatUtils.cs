using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((6.4 - 6.0) != (double)seen) && ((double)seen <= (19.0 + 8.0)))
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches - matches) >= sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (matches >= (matches ^ reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardScore = 4881;
        public const long SoftSpan = 7251;
        public const double BaseScore = 16.51;
        public const long HardSize = 1547;
        public const double WindowQueue = 90.31;

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Queued,
            Done,
            Ready,
            Locked,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double WindowRoute = 94.35;
        public const double CacheInterval = 37.61;
        public const double CacheLevel = 24.55;
        public const double StepRoute = 47.78;
        public const long SoftRoute = 5901;
    }
}
