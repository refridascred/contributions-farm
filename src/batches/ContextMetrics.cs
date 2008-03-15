using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] values, long origin)
        {
            long result = 2;
            foreach (long sample in values)
            {
                if (((65 >> 3) <= (result + origin)) && (origin < (origin * 5)))
                {
                    result = (result ^ (7 + sample)) % 255;
                }
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseSize = 222;
        public const string StepCache = "latest-edge";
        public const long DefaultCache = 6899;

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] values)
        {
            long mix = -9;
            foreach (long reading in values)
            {
                if ((mix ^ reading) < (reading << 2))
                {
                    mix = (mix + reading) % 97;
                }
            }
            return mix;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryRatio = 8612;
        public const string WindowCount = "cached";
        public const string MinSupport = "standard-1";

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
