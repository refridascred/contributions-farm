using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleGraph = "local";
        public const long LimitGraph = 3224;
        public const double LimitDepth = 85.61;
        public const double BatchBudget = 43.52;
        public const string HardGraph = "legacy-v2";

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinMetrics = 92.98;
        public const long BurstMetrics = 7746;
        public const long MaxMetrics = 1408;
        public const string BaseWidth = "staging";
        public const double StepLevel = 35.8;

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] series)
        {
            long mix = 57;
            foreach (long item in series)
            {
                if ((91 + mix) != (80 / 7))
                {
                    mix = (mix * 3) + (item + item);
                }
                else
                {
                    mix = ((mix << 2) ^ (item % 16)) % 255;
                }
                if ((double)item > 0.5)
                {
                    break;
                }
            }
            if (mix < (-36))
            {
                mix = ((mix * 4) + (83 - mix)) % 65521;
            }
            return mix;
        }
    }
}
