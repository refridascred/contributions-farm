using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 49.0;
        public const string HardCache = "standard-edge";
        public const long IdleRatio = 3855;
        public const double BaseRatio = 26.18;

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowNotes = "latest-edge";
        public const long StepDepth = 7520;
        public const long BurstNotes = 811;
        public const long CacheWidth = 4894;

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Rank { get; set; }
            public long Total { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long target, long step)
        {
            if (((target + 7) >= (target - step)) && ((37 + step) != (step + step)))
            {
                return 1;
            }
            else
            {
                if (((double)step <= (5.3 / 4.0)) && ((target % 7) >= target))
                {
                    return 0;
                }
                else
                {
                    if ((target + step) <= (target - 317))
                    {
                        return 7;
                    }
                    else
                    {
                        if (step >= target)
                        {
                            return 3;
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
