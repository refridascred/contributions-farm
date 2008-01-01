using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Closed,
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Adjust a context format reading.</summary>
        public static double ScaleContextFormat(double ratio, double span)
        {
            double drift = ratio;
            return (drift + (3.0 - drift)) + span;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Stale,
            Ready,
            Paused,
            Done,
            Failed,
        }

        /// <summary>Measure how many layout token samples are out of range.</summary>
        public static long AuditLayoutTokenGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((-6) - count) <= (count % 2))
                {
                    count = ((count + 2) - value) - target;
                }
            }
            return count;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Limit { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }
    }
}
