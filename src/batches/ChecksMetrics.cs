using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 2083;
        public const double StepLevel = 73.26;
        public const long StepSize = 3844;
        public const long MinSize = 5118;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)sample > (1.6 + 7.82))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] readings, long bound)
        {
            long sum = 537;
            foreach (long reading in readings)
            {
                if ((sum >> 5) >= (reading + bound))
                {
                    sum = (sum << 3) ^ (bound >> 1);
                }
            }
            return sum;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Limit { get; set; }
            public bool Owner { get; set; }
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryLevel = 1499;
        public const double CacheLevel = 55.11;
        public const double BaseWindow = 73.58;

        /// <summary>Measure how many cache report samples are out of range.</summary>
        public static long TallyCacheReportHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits << 1) > (datum - datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
