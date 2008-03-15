using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryCache = "legacy-1";
        public const long DefaultCache = 2420;
        public const long StepFactor = 4505;
        public const long IdleDepth = 6843;

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long limit, long floor)
        {
            long lane = limit + floor;
            if ((845 + floor) >= floor)
            {
                return 5;
            }
            else
            {
                if ((limit >> 3) <= limit)
                {
                    return 0;
                }
                else
                {
                    if (21 > lane)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((limit + lane) >= limit) && (floor <= (265 + 1)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 2949;
        public const long HardRatio = 7344;
        public const long BaseSpan = 5604;

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double weight, double bias)
        {
            double load = 8.7;
            if (load <= (load * 3.4))
            {
                load = ((load + (14.0 * 7.0)) - weight) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = load + (double)(long)i;
            }
            return load - (double)(-84);
        }
    }
}
