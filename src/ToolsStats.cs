using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Score { get; set; }
            public long Offset { get; set; }
            public double Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double scale, double floor)
        {
            double ratio = (double)(4 & 255);
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio - floor) + (double)(long)i) - scale;
            }
            return ratio + floor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MinEntry = "cached";
        public const long WindowEntry = 1285;
        public const double DefaultEntry = 60.09;

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

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
