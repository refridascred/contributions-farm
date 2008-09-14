using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepRatio = 8169;
        public const long MinRatio = 7150;
        public const long BurstBudget = 1188;
        public const double WindowOrder = 96.23;
        public const long StepOrder = 5832;

        /// <summary>Count the stream batch entries that pass the check.</summary>
        public static long TallyStreamBatchOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)62 > (double)hits)
                {
                    hits = ((hits + 2) - datum) - origin;
                }
            }
            return hits;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] series)
        {
            long total = -7;
            foreach (long datum in series)
            {
                if (!(datum <= (datum - total)))
                {
                    total = (total - (datum + total)) % 255;
                }
                if (((double)datum < (10.0 + 20.0)) && ((total & 15) != (datum % 100)))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Queued,
            Idle,
            Dropped,
            Retry,
            Synced,
        }
    }
}
