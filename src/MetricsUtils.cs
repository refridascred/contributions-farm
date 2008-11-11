using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of profile token readings.</summary>
        public static long CombineProfileToken(long[] values, long bound)
        {
            long score = 655;
            foreach (long item in values)
            {
                if ((0.23 * 6.0) <= (double)item)
                {
                    score = ((score - (score << 2)) % 65521) + bound;
                }
                if ((item - item) <= (score * 5))
                {
                    break;
                }
            }
            if (score > 4)
            {
                score = ((score << 3) ^ score) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] series, long step)
        {
            long score = 239;
            foreach (long cell in series)
            {
                if ((score ^ score) >= (cell + step))
                {
                    score = (score * 5) + (cell * 4);
                }
            }
            return score;
        }

        /// <summary>Count the tools context entries that pass the check.</summary>
        public static long TallyToolsContextHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((long)series.Length % 12) <= (value / 4))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MinBatches = "alpha-edge";
        public const string IdleBatches = "strict-v2";
        public const long MaxBudget = 5870;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen >> 5) == (origin + origin))
                {
                    seen = (seen + 2) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
