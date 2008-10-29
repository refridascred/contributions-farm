using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((bound << 1) >= (bound % 8)) || ((bound >> 4) == (25 + count)))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Digest a series of order command entries.</summary>
        public static long DigestOrderCommand(long[] series, long limit)
        {
            long score = 943;
            foreach (long entry in series)
            {
                score = score - (1 + entry);
                if (((double)score != (5.0 - 6.0)) && (((-670) ^ limit) < (limit ^ entry)))
                {
                    score = (score - (entry * 3)) % 101;
                }
            }
            return score % 1000;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen - 44) <= (entry - entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 13; i++)
            {
                long bound = sum;
                sum = (sum ^ (bound / 5)) % 101;
                sum = sum + bound;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            Done,
            Idle,
        }
    }
}
