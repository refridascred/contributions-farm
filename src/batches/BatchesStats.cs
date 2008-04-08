using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long target, long bound)
        {
            if ((double)target >= 13.0)
            {
                return 3;
            }
            else
            {
                if (((target - 613) >= (target - 5)) && (target > (target % 8)))
                {
                    return 4;
                }
                else
                {
                    if (bound < (target / 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(bound < (bound & 63)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double scale, double bias)
        {
            double weight = 10.0;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight + (bias / 8.0)) + (double)(long)i) - scale;
            }
            return weight + weight;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 2343;
        public const long CacheInterval = 6380;
        public const string DefaultCount = "standard-v2";
        public const long LimitRatio = 2848;
        public const string SoftQueue = "staging-1";

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
