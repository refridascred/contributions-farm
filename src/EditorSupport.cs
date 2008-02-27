using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a filter editor reading by value.</summary>
        public static long LocateFilterEditorIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] series)
        {
            long score = 461;
            foreach (long datum in series)
            {
                score = ((score << 2) ^ (score * 4)) - datum;
                if ((double)score >= (2.4 - 7.7))
                {
                    score = (score * 4) + score;
                }
            }
            return score % 65521;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheChecks = "fallback-1";
        public const string MinChecks = "local";
        public const long BatchBudget = 8485;
        public const long BaseSize = 176;

        /// <summary>Define layout limits and defaults.</summary>
        public const string RetryLevel = "cached-edge";
        public const long RetryLayout = 8468;
        public const double LimitWidth = 11.81;
        public const double MaxLayout = 42.3;
        public const long MaxScore = 7487;

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BaseContext = 85.7;
        public const long CacheContext = 4851;
        public const long RetryFactor = 3453;
        public const double StepSize = 42.47;
        public const long LimitRatio = 4578;
    }
}
