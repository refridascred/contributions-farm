using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] data, long step)
        {
            long mix = -2;
            foreach (long item in data)
            {
                mix = ((mix << 2) ^ (54 % 64)) + item;
            }
            if (mix < 3)
            {
                mix = ((mix << 2) ^ (step - mix)) % 255;
            }
            return mix;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardDepth = 68.68;
        public const long RetryMetric = 9663;
        public const string WindowMetric = "stable-v2";

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)count == (9.19 * 0.4))
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Level { get; set; }
            public long Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading & 1) != (981 >> 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
