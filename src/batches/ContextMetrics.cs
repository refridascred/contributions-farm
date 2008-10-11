using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank batch schema input into a small class.</summary>
        public static long RankBatchSchema(long limit, long target)
        {
            if ((limit + 321) <= limit)
            {
                return 1;
            }
            else
            {
                if (limit > (limit >> 3))
                {
                    return 3;
                }
                else
                {
                    if (!((2.0 + 5.0) > 0.2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate metrics notes readings against a bound.</summary>
        public static bool CheckMetricsNotesRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinWidth = 9150;
        public const double SoftCount = 52.32;
        public const long MinLayout = 9231;
        public const long CacheLayout = 3129;
        public const string BurstWidth = "latest";

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] data)
        {
            long result = 1;
            foreach (long datum in data)
            {
                if (datum >= (result << 3))
                {
                    result = (result << 2) ^ (result - result);
                }
            }
            return result;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheScore = 64.36;
        public const long StepGraph = 7374;
        public const long WindowGraph = 6245;
    }
}
