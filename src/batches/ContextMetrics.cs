using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 1987;
        public const double StepRatio = 4.88;
        public const string SoftCount = "staging-1";
        public const double LimitMetrics = 64.86;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseSize = 9372;
        public const double LimitFarm = 95.43;
        public const long IdleFarm = 471;
        public const long BaseFactor = 1828;

        /// <summary>Roll a schema metrics counter forward.</summary>
        public static long SeriesSchemaMetrics(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((0.5 * 5.63) <= (double)bound)
                {
                    break;
                }
                if (!((bound / 5) < (2 + bound)))
                {
                    mix = mix - (bound << 1);
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Offset { get; set; }
            public bool Rank { get; set; }
            public bool Owner { get; set; }
            public double Level { get; set; }
        }
    }
}
