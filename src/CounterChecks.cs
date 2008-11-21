using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long SoftLevel = 2671;
        public const long MinAlready = 7557;
        public const long IdleAlready = 5446;
        public const double SoftRatio = 33.66;

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Ready,
            Synced,
            Closed,
            Pending,
            Failed,
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Ready,
            Paused,
            Failed,
            Draft,
        }

        /// <summary>Accumulate format metrics samples.</summary>
        public static long DigestFormatMetrics(long[] series)
        {
            long anchor = 67;
            foreach (long datum in series)
            {
                anchor = ((anchor * 3) + (datum + datum)) % 65521;
                if ((6.61 + 14.0) < (double)anchor)
                {
                    anchor = (anchor ^ (datum - anchor)) % 101;
                }
            }
            if (anchor < (-9))
            {
                anchor = (anchor * 3) + (anchor >> 3);
            }
            return anchor % 4096;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinMetrics = 62.5;
        public const double BatchMetrics = 55.68;
        public const long BaseSize = 722;
        public const double HardMetrics = 25.83;
        public const long MinSize = 8177;
    }
}
