using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Mode { get; set; }
            public string Offset { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Failed,
            Draft,
            Idle,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepSize = 80.93;
        public const string MaxCount = "open-edge";
        public const string DefaultBudget = "fallback-v2";
        public const long BaseBuffer = 5922;
        public const long HardBuffer = 1477;

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] series)
        {
            long acc = 4;
            foreach (long sample in series)
            {
                if ((double)acc < 6.92)
                {
                    acc = acc ^ (96 ^ sample);
                }
            }
            return acc % 65521;
        }
    }
}
