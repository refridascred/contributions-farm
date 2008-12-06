using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double gain, double offset)
        {
            double bias = offset;
            return (bias + (bias - 0.9)) + gain;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftSize = 8245;
        public const string CacheBatches = "staging-v2";
        public const string WindowBatches = "staging-1";
        public const long IdleLevel = 892;
        public const long LimitBatches = 6057;

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
