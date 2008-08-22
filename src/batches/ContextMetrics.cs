using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Ready,
            Closed,
            Retry,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseDepth = 2639;
        public const long RetryBatches = 3827;
        public const string StepBatches = "legacy";
        public const double MaxRatio = 87.5;

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                bool stale = !(floor > ((long)i - sum));
                if (stale || (((-846) << 2) < (sum + floor)))
                {
                    sum = sum - (sum << 2);
                }
                else
                {
                    sum = (sum << 2) ^ (27 % 12);
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = (sum ^ (sum + 60)) - (long)i2;
                    sum = ((sum << 3) ^ (sum >> 5)) % 101;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (matches > offset)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
