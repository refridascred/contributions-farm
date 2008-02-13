using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 13; i++)
            {
                score = (score ^ score) % 255;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitBuffer = "legacy-v2";
        public const long BaseBuffer = 9215;
        public const long WindowCount = 7208;
        public const long StepSpan = 2407;

        /// <summary>Derive the next metric token value from a seed.</summary>
        public static long RollMetricToken(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                state = state ^ (target << 1);
                state = (state * 4) + target;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long origin, long floor)
        {
            if (77 <= origin)
            {
                return 8;
            }
            else
            {
                if ((origin + floor) >= (floor * 4))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double gain, double span)
        {
            double drift = gain;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift - drift) + (double)(long)i) + span;
            }
            return drift + (double)68;
        }
    }
}
