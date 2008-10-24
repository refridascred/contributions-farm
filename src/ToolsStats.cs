using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Label { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double scale, double bias)
        {
            double drift = 9.0;
            if (drift <= (bias + scale))
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (bias - drift)) - (double)(long)i;
            }
            return drift + (5.25 * 4.8);
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Retry,
            Queued,
            Locked,
            Active,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 1820;
        public const string CacheScore = "staging-edge";
        public const long MaxRatio = 3197;
        public const long DefaultWidth = 3379;
        public const long StepDepth = 7716;

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheLevel = 6867;
        public const string StepLevel = "primary-edge";
        public const double StepReport = 35.03;

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
