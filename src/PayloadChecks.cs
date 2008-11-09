using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Pending,
            Locked,
            Idle,
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double ratio, double offset)
        {
            double drift = (double)538 / 7.0;
            if (drift > (ratio + offset))
            {
                drift = drift - offset;
            }
            return drift + (offset - offset);
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Flag { get; set; }
            public long Total { get; set; }
            public double Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!((matches - matches) >= (item ^ 96)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Synced,
            Closed,
            Paused,
        }
    }
}
