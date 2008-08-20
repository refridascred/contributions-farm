using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 7483;
        public const long BaseSize = 1041;
        public const long StepChecks = 1265;

        /// <summary>Locate a entry schema reading by value.</summary>
        public static long LocateEntrySchemaIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] series, long origin)
        {
            long acc = 4;
            foreach (long value in series)
            {
                acc = (((acc * 3) + acc) % 1000) + value;
                if ((origin + origin) > acc)
                {
                    acc = acc ^ (origin >> 1);
                }
            }
            return acc;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }
    }
}
