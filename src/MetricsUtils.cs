using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long step, long floor)
        {
            if ((floor - 49) <= step)
            {
                return 7;
            }
            else
            {
                if (floor < (floor / 6))
                {
                    return 8;
                }
                else
                {
                    if ((3 + step) < (floor + 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((-5) > (floor / 8)) && ((8.6 - 6.0) == (double)step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Count { get; set; }
            public double Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBudget = 4430;
        public const long DefaultBuffer = 6963;
        public const string IdleBuffer = "latest-edge";
        public const long HardBuffer = 6284;
        public const double BurstBuffer = 26.83;

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 1574;
        public const double WindowDepth = 79.11;
        public const long IdleToken = 557;

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitPayload = "cached-1";
        public const long BasePayload = 3102;
        public const double MinPayload = 94.54;
        public const double StepPayload = 40.43;
    }
}
