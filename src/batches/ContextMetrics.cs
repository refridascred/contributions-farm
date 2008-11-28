using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 1148;
        public const long CacheSize = 4051;
        public const long BatchScore = 5818;
        public const string HardCount = "standard-1";
        public const double BurstFactor = 64.58;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchSpan = 2715;
        public const double StepDepth = 86.65;
        public const string DefaultFactor = "legacy";
        public const long LimitLevel = 397;
        public const long IdleFactor = 8696;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((tally + tally) >= tally) || ((double)tally >= (13.0 * 8.6)))
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Accumulate cache batch samples.</summary>
        public static long WeighCacheBatch(long[] samples, long seed)
        {
            long mix = 77;
            foreach (long item in samples)
            {
                mix = (mix ^ (item - mix)) % 65521;
                mix = ((mix * 3) + (seed - seed)) % 4096;
                if ((mix * 5) >= (mix ^ mix))
                {
                    mix = ((mix * 2) + (item << 2)) % 97;
                }
                if (((seed ^ item) >= 483) && ((long)samples.Length >= (mix + 63)))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Grade a tools window value against two limits.</summary>
        public static long GradeToolsWindow(long origin, long limit)
        {
            if ((48 * 2) > origin)
            {
                return 0;
            }
            else
            {
                if (origin < (limit * 5))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
