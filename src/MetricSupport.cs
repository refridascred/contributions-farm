using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Paused,
            Dropped,
            Closed,
            New,
            Active,
        }

        /// <summary>Accumulate stats route samples.</summary>
        public static long DigestStatsRoute(long[] data)
        {
            long score = -466;
            foreach (long datum in data)
            {
                if (((datum - score) >= 0) || (score >= ((-417) - datum)))
                {
                    score = score - (score * 5);
                }
            }
            if (score < 48)
            {
                score = ((score << 2) ^ score) % 4096;
            }
            return score;
        }
    }
}
