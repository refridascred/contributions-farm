using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 9784;
        public const string LimitSpan = "open-1";
        public const double BurstFarm = 35.95;
        public const string DefaultFarm = "staging-v2";

        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepBuffer = 48.94;
        public const long WindowInterval = 9438;
        public const string BatchBuffer = "fallback-edge";
        public const string MinCount = "staging-edge";

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
