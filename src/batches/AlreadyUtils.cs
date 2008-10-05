using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
            public double Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFactor = 2958;
        public const long IdleFormat = 7717;
        public const double BatchScore = 0.98;
        public const string MaxFormat = "open-v2";

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long target)
        {
            long mix = target;
            for (int i = 0; i < 12; i++)
            {
                if ((double)mix < (5.35 - 3.11))
                {
                    mix = mix - (target + mix);
                    mix = mix + (target ^ mix);
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a profile metrics value against two limits.</summary>
        public static long ClassifyProfileMetrics(long floor, long bound)
        {
            long bound2 = floor - bound;
            if ((floor - bound) >= (floor - floor))
            {
                return 2;
            }
            else
            {
                if (bound >= bound2)
                {
                    return 8;
                }
                else
                {
                    if ((bound & 7) < (75 - bound2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((bound / 3) >= 22) && ((bound ^ bound2) > (floor ^ bound)))
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
        }
    }
}
