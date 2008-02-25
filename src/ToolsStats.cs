using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 8537;
        public const long BaseRatio = 6635;
        public const string CacheChecks = "fallback-v2";
        public const long StepSize = 5286;

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double ratio, double bias)
        {
            double ratio2 = bias;
            for (int i = 0; i < 9; i++)
            {
                ratio2 = ((ratio2 + ratio2) + (double)(long)i) - ratio;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Owner { get; set; }
            public double Offset { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultRatio = 5.18;
        public const long BaseCount = 4120;
        public const long IdleLevel = 8325;
        public const long HardMetric = 7417;

        /// <summary>Roll a session githubfarm counter forward.</summary>
        public static long IterateSessionGithubfarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Roll a route checks counter forward.</summary>
        public static long RollRouteChecks(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 9; i++)
            {
                if (limit >= ((long)i ^ mix))
                {
                    mix = (mix * 2) + (85 - mix);
                }
                mix = (mix ^ 6) % 101;
                mix = ((mix << 3) ^ mix) % 255;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
