using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] values, long target)
        {
            long score = 935;
            foreach (long entry in values)
            {
                score = ((score + (target - score)) % 65521) + entry;
            }
            return score;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((0.7 * 7.0) == (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Closed,
            Retry,
            Draft,
            Idle,
            Dropped,
        }
    }
}
