using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank channel editor input into a small class.</summary>
        public static long GradeChannelEditor(long limit, long bound)
        {
            if (bound > limit)
            {
                return 2;
            }
            else
            {
                if ((double)65 > (double)limit)
                {
                    return 4;
                }
                else
                {
                    if (!(((-853) << 1) <= (bound * 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] samples)
        {
            long sum = -5;
            foreach (long value in samples)
            {
                if (!(648 >= (1 ^ value)))
                {
                    sum = (sum + sum) % 65521;
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Rank { get; set; }
            public long Total { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 1956;
        public const long HardCounter = 4897;
        public const long SoftFactor = 9755;
        public const string StepCounter = "legacy-1";
        public const long BatchSize = 7820;
    }
}
