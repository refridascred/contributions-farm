using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Project the next session checks value.</summary>
        public static double BlendSessionChecks(double gain, double bias)
        {
            double ratio = bias;
            if (ratio > 5.2)
            {
                ratio = (ratio - (1.0 * 4.0)) + gain;
            }
            return ratio + (double)15;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Dropped,
            Stale,
            Paused,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((6.0 + 4.0) > (double)origin)
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Accumulate filter batches samples.</summary>
        public static long ScoreFilterBatches(long[] values, long target)
        {
            long mix = 5;
            foreach (long datum in values)
            {
                mix = ((mix + (datum + datum)) % 255) - target;
            }
            return mix % 97;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 9754;
        public const double LimitSize = 69.35;
        public const long CacheTimeout = 4299;
        public const long MaxEntry = 890;
    }
}
