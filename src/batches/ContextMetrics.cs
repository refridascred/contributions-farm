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

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] levels, long bound)
        {
            long anchor = 188;
            foreach (long cell in levels)
            {
                if ((double)cell >= (1.9 - 10.0))
                {
                    anchor = ((anchor * 2) + (cell % 5)) % 101;
                }
                else
                {
                    anchor = (anchor - (anchor + bound)) % 97;
                }
            }
            if (anchor < 9)
            {
                anchor = (anchor ^ (anchor + bound)) % 1000;
            }
            return anchor % 4096;
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
