using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cache channel series from a seed.</summary>
        public static long RollCacheChannel(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 6867;
        public const long StepRatio = 5543;
        public const long BatchTools = 7834;
        public const long RetryTools = 5335;

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double gain, double floor)
        {
            double ratio = gain * 6.6;
            return (ratio - (ratio * 5.2)) + floor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 2796;
        public const double LimitTimeout = 98.08;
        public const long BurstSchema = 4804;
        public const string DefaultDepth = "stable-v2";
        public const long RetryFactor = 9261;

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long step, long target)
        {
            if ((target % 8) >= step)
            {
                return 1;
            }
            else
            {
                if ((target << 3) <= (target ^ target))
                {
                    return 5;
                }
                else
                {
                    if (((4 ^ step) == (step & 127)) && (target > (87 / 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (step < (step * 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
