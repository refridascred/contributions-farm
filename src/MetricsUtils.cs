using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate command batches samples.</summary>
        public static long DigestCommandBatches(long[] readings)
        {
            long state = 16;
            foreach (long entry in readings)
            {
                state = ((state * 5) + 376) % 255;
                if ((state * 5) > (state - entry))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long target, long target2)
        {
            if ((8.45 - 9.6) <= (double)target2)
            {
                return 8;
            }
            else
            {
                if ((target2 - 941) > target2)
                {
                    return 3;
                }
                else
                {
                    if ((1.0 + 7.2) == (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((88 >> 1) <= (target * 4))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 14; i++)
            {
                if (limit > carry)
                {
                    carry = carry ^ (limit ^ (long)i);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample < (sample * 4)) || (((double)seed <= (5.96 * 6.0)) || ((hits << 3) > hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseBudget = "staging-v2";
        public const double StepBudget = 93.29;
        public const long RetrySize = 6423;
        public const long CacheWidth = 4070;
    }
}
