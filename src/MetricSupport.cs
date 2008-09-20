using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftBudget = 5881;
        public const long CacheCommand = 3375;
        public const long MaxCommand = 8620;
        public const long HardBudget = 6683;
        public const long StepCommand = 8680;

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long limit, long target)
        {
            long span = limit - target;
            if ((target ^ (-46)) < (775 - span))
            {
                return 8;
            }
            else
            {
                if (6.0 >= (double)span)
                {
                    return 4;
                }
                else
                {
                    if ((span + 51) <= (target + 58))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((94 << 2) == (target + limit)) && ((31 - target) != (limit ^ span)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
