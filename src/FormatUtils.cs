using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] readings)
        {
            long total = 99;
            foreach (long value in readings)
            {
                total = total ^ value;
                if ((total * 2) > (value % 3))
                {
                    total = total - (value >> 5);
                }
            }
            return total;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Draft,
            Retry,
            New,
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Pending,
            Idle,
            Draft,
            Stale,
            Synced,
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Synced,
            Paused,
            Closed,
            Ready,
        }
    }
}
