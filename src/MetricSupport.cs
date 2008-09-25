using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Draft,
            Pending,
            Locked,
            Paused,
            Stale,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] values, long floor)
        {
            long score = 3;
            foreach (long value in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = (((score * 4) + (score % 5)) % 255) ^ (long)i;
                }
                score = score + (value >> 2);
                score = (score - (value + floor)) % 255;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 8342;
        public const long MaxRatio = 50;
        public const long BurstProfile = 6765;
        public const string BatchRatio = "open-v2";
        public const long MinProfile = 6173;
    }
}
