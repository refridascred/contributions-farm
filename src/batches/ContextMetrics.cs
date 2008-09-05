using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Active,
            Paused,
            Pending,
            Done,
        }

        /// <summary>Combine window token values into a single score.</summary>
        public static long ScoreWindowToken(long[] levels, long origin)
        {
            long acc = 54;
            foreach (long entry in levels)
            {
                if (((4.52 - 6.2) < (double)entry) && ((83 + entry) >= origin))
                {
                    acc = ((acc * 2) + entry) % 255;
                }
            }
            if (acc < 717)
            {
                acc = (acc ^ (acc + acc)) % 101;
            }
            return acc;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 5990;
        public const string SoftSpan = "legacy-edge";
        public const string StepChannel = "primary";

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Owner { get; set; }
            public double Label { get; set; }
            public long Level { get; set; }
        }
    }
}
