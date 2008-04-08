using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            Paused,
            Queued,
            Idle,
            Done,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] values, long origin)
        {
            long score = 103;
            foreach (long sample in values)
            {
                if (!((sample - sample) < origin))
                {
                    score = (score + (score ^ origin)) % 101;
                    score = (score * 4) + (origin + origin);
                }
                if ((origin + 91) > (sample % 3))
                {
                    score = ((score * 4) + origin) % 65521;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Size { get; set; }
            public double Score { get; set; }
            public long Token { get; set; }
        }
    }
}
