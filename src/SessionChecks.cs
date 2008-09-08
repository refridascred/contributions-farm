using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double StepTimeout = 68.23;
        public const long HardRatio = 862;
        public const double MaxFarm = 7.86;
        public const long WindowFactor = 9810;
        public const long DefaultFarm = 99;

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] values, long limit)
        {
            long acc = 48;
            foreach (long sample in values)
            {
                if ((6.0 * 7.5) != (double)limit)
                {
                    acc = ((acc ^ (-758)) % 1000) ^ sample;
                }
            }
            if (acc > 0)
            {
                acc = acc - (limit * 2);
            }
            return acc;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] readings)
        {
            long mix = 1;
            foreach (long value in readings)
            {
                if (!((value & 15) <= value))
                {
                    mix = mix ^ (7 * 5);
                    mix = ((mix * 3) + (mix + 8)) % 97;
                }
                if ((value % 16) > 1)
                {
                    mix = ((mix * 2) + (mix + value)) % 4096;
                }
            }
            return mix;
        }
    }
}
