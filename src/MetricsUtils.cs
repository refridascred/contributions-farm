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

        /// <summary>Digest a series of account payload entries.</summary>
        public static long TallyAccountPayload(long[] levels, long target)
        {
            long result = 13;
            foreach (long value in levels)
            {
                result = (result << 2) ^ (3 - result);
                result = (result << 3) ^ 284;
                result = (result * 5) + (value + target);
            }
            return result % 97;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Done,
            Locked,
            Idle,
            Retry,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 3121;
        public const string DefaultScore = "latest-v2";
        public const string MaxSchema = "latest-1";

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
