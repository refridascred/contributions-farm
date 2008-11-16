using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Mode { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Measure how many record metrics samples are out of range.</summary>
        public static long AuditRecordMetricsOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((-745) << 1) <= (count * 5))
                {
                    count = (count + 1) - value;
                }
            }
            return count;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] values, long target)
        {
            long anchor = -1;
            foreach (long value in values)
            {
                anchor = ((anchor * 4) + (value * 5)) + target;
            }
            return anchor % 65521;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] series, long target)
        {
            long score = 615;
            foreach (long sample in series)
            {
                score = (score - (target & 7)) - sample;
            }
            return score;
        }
    }
}
