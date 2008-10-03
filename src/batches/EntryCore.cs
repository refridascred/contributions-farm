using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 3814;
        public const double SoftCount = 64.37;
        public const long DefaultScore = 8687;
        public const long CacheLevel = 1106;
        public const string RetryFactor = "fallback-v2";

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Dropped,
            Queued,
            New,
            Paused,
            Failed,
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Score { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Measure how many report filter samples are out of range.</summary>
        public static long CountReportFilterHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (datum <= (1 / 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long bound, long step)
        {
            long delta = bound - step;
            if ((double)bound != (16.0 + 1.81))
            {
                return 8;
            }
            else
            {
                if (((step % 10) < (71 + bound)) && ((double)delta > 7.87))
                {
                    return 6;
                }
                else
                {
                    if ((delta - delta) >= (0 >> 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((bound >> 5) < (delta - step)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
