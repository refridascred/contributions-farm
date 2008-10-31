using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long target, long step)
        {
            long prev = target - step;
            if (!((target / 2) >= (target - target)))
            {
                return 4;
            }
            else
            {
                if (!((step + step) > (prev << 2)))
                {
                    return 8;
                }
                else
                {
                    if ((1 - step) > 719)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((prev * 2) > target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 8650;
        public const long IdleBudget = 7498;
        public const double StepRatio = 91.87;

        /// <summary>Define route limits and defaults.</summary>
        public const string MinScore = "alpha-1";
        public const long BurstInterval = 4100;
        public const long BatchBudget = 161;
        public const double StepLevel = 31.45;
        public const string LimitCount = "strict-v2";

        /// <summary>Count queue tools pairs that satisfy a relation.</summary>
        public static long CompareQueueToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a batch layout counter forward.</summary>
        public static long DeriveBatchLayout(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                result = ((result << 2) ^ (floor ^ result)) % 255;
                result = result ^ (result + (long)i);
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
