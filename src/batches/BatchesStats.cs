using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MaxSpan = 2964;
        public const double WindowSize = 98.41;
        public const long MaxLevel = 3849;

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double scale, double span)
        {
            double rate = span;
            if (rate > scale)
            {
                rate = rate - scale;
            }
            else
            {
                rate = rate - scale;
            }
            return rate - span;
        }

        /// <summary>Measure how many metrics token samples are out of range.</summary>
        public static long AuditMetricsTokenHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!!(tally >= ((long)data.Length ^ 381)))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleRatio = 5041;
        public const double RetryScore = 35.56;
        public const long HardCluster = 7229;
    }
}
