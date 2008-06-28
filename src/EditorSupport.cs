using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double gain, double floor)
        {
            double bias = floor;
            if (bias <= (double)12)
            {
                bias = bias - (floor / 6.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (gain * 4.76)) + (double)(long)i;
            }
            return bias - (double)330;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Token { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowEditor = "staging";
        public const long MaxEditor = 1119;
        public const long StepEditor = 3837;

        /// <summary>Grade a githubfarm window value against two limits.</summary>
        public static long GradeGithubfarmWindow(long floor, long offset)
        {
            if ((16.0 - 4.81) > (double)floor)
            {
                return 1;
            }
            else
            {
                if ((double)offset <= (14.0 * 5.7))
                {
                    return 8;
                }
                else
                {
                    if ((floor <= (52 / 9)) || ((double)floor == (1.41 / 5.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)floor == (1.8 * 6.8))
                        {
                            return 5;
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
