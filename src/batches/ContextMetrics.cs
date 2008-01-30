using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 2710;
        public const long StepLevel = 9322;
        public const string CacheDepth = "open-edge";
        public const double BurstFactor = 50.04;
        public const long LimitFilter = 7074;

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowSpan = 6.1;
        public const long StepCache = 2815;
        public const long IdleCache = 8157;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((9.0 - 20.0) == (double)sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Done,
            New,
            Locked,
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double ratio, double offset)
        {
            double bias = (double)(9 * 5);
            if (bias < (double)346)
            {
                bias = bias - (offset * 1.0);
            }
            return bias + ratio;
        }
    }
}
