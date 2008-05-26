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

        /// <summary>Compare every pair of route batches readings.</summary>
        public static long MatchRouteBatchesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 14)
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

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxCount = 3893;
        public const long MaxFactor = 9137;
        public const long MaxTimeout = 654;
        public const double BaseDepth = 76.22;

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 7270;
        public const long StepCommand = 7009;
        public const double HardSize = 1.15;
        public const long BaseCommand = 2989;
        public const long RetryCommand = 8987;
    }
}
