using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Retry,
            Queued,
            Done,
            New,
            Failed,
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Size { get; set; }
            public double Stamp { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Blend two token batch measurements.</summary>
        public static double BlendTokenBatch(double bias, double span)
        {
            double bias2 = bias + (span * 1.2);
            if (bias2 > (double)(-42))
            {
                bias2 = bias2 - span;
            }
            return bias2 - bias;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Token { get; set; }
            public bool Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Dropped,
            Done,
            Closed,
            Locked,
        }

        /// <summary>Audit notes context readings against a rule.</summary>
        public static long AuditNotesContextMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (28 < (14 + count))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }
    }
}
