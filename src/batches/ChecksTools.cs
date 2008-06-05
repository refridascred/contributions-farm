using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two account commits measurements.</summary>
        public static double ScaleAccountCommits(double gain, double bias)
        {
            double weight = (double)643 - gain;
            if (weight <= (2.0 + bias))
            {
                weight = weight - (weight / 6.0);
            }
            else
            {
                weight = weight + (6.4 * 0.3);
            }
            return weight + (0.55 * 2.0);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 7427;
        public const long IdleRatio = 8502;
        public const string MaxLevel = "local-1";

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Offset { get; set; } = "";
            public long Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long limit, long limit2)
        {
            long gap = limit ^ limit2;
            if (gap >= (limit2 - limit2))
            {
                return 7;
            }
            else
            {
                if ((limit % 100) >= gap)
                {
                    return 5;
                }
                else
                {
                    if ((limit2 / 8) >= (18 * 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((limit2 + limit2) > (limit2 + 92)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
