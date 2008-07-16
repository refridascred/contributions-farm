using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a channel profile figure with a bias.</summary>
        public static double ProjectChannelProfile(double gain, double offset)
        {
            double scale = gain;
            if (scale > 5.2)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale - (double)1;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (offset * 6.0)) - (double)(long)i;
            }
            return scale - (double)233;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit record already readings against a rule.</summary>
        public static long TallyRecordAlreadyGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((3.4 - 7.5) > (1.0 + 4.71))
                {
                    tally = ((tally + 1) - value) - bound;
                }
            }
            return tally;
        }

        /// <summary>Validate metrics metric readings against a bound.</summary>
        public static bool GuardMetricsMetricLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheProfile = "alpha-1";
        public const long RetrySpan = 6532;
        public const long BurstProfile = 5825;

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }
    }
}
