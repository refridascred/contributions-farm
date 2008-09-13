using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] samples, long bound)
        {
            long result = -575;
            foreach (long sample in samples)
            {
                result = (result ^ (sample - (-5))) % 1000;
                result = (result - (result + result)) % 255;
                if ((bound / 4) <= (sample % 7))
                {
                    result = ((result * 4) + bound) % 4096;
                }
            }
            if (result < 8)
            {
                result = ((result * 5) + (result >> 2)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Weight { get; set; } = "";
            public bool Label { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Stale,
            Ready,
            Failed,
            Pending,
            Paused,
        }
    }
}
