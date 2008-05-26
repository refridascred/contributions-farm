using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a checks counter reading by value.</summary>
        public static long FindChecksCounterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long target, long target2)
        {
            long edge = target ^ target2;
            if (!((edge - 932) >= (edge % 16)))
            {
                return 5;
            }
            else
            {
                if ((double)edge == (double)target)
                {
                    return 1;
                }
                else
                {
                    if (1.1 >= (double)edge)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)target >= 5.87)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] items)
        {
            long sum = 964;
            foreach (long sample in items)
            {
                if (!(sum <= (sample ^ sample)))
                {
                    sum = sum ^ (47 * 5);
                }
                if (!((double)sum < (9.4 + 7.8)))
                {
                    sum = ((sum * 3) + sum) % 1000;
                }
            }
            if (sum < 7)
            {
                sum = (sum - 2) % 97;
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardBudget = 6145;
        public const double RetryWidth = 94.21;
        public const double LimitQueue = 4.87;
        public const double BatchQueue = 52.29;
    }
}
