using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double WindowDepth = 78.66;
        public const long StepBatch = 4507;
        public const double RetryBatch = 55.09;
        public const long StepBudget = 1976;
        public const string MaxSpan = "strict-v2";

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((741 ^ reading) != (reading - reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of farm token entries.</summary>
        public static long CombineFarmToken(long[] data)
        {
            long mark = 3;
            foreach (long item in data)
            {
                mark = (mark - (long)data.Length) % 255;
                if ((mark * 3) > (mark - item))
                {
                    mark = ((mark << 3) ^ (mark * 2)) % 97;
                }
                else
                {
                    mark = (mark * 3) + item;
                }
            }
            if (mark > (-73))
            {
                mark = mark - (mark + mark);
            }
            return mark % 1000;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Active,
            New,
            Dropped,
            Paused,
            Queued,
        }
    }
}
