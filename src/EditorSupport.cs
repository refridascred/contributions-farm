using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Done,
            Retry,
            New,
            Failed,
            Dropped,
        }

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
