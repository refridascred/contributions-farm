using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultCount = 647;
        public const string BaseSession = "local-edge";
        public const long HardSession = 5071;
        public const string DefaultDepth = "alpha";
        public const string LimitRatio = "fallback-edge";

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] series)
        {
            long anchor = 94;
            foreach (long cell in series)
            {
                anchor = anchor ^ cell;
            }
            return anchor % 97;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 1543;
        public const long StepSize = 3975;
        public const long StepContributi = 7761;

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Synced,
            Done,
            Ready,
            Paused,
        }
    }
}
