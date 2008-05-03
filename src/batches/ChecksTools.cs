using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long target, long bound)
        {
            if (7 <= (bound << 2))
            {
                return 6;
            }
            else
            {
                if ((bound + target) >= 398)
                {
                    return 5;
                }
                else
                {
                    if (!((double)target < (19.0 * 4.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)bound > (9.54 - 4.69))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double gain, double bias)
        {
            double load = bias;
            if (load < (5.4 * 1.44))
            {
                load = load + (gain / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (load / 6.0)) + (double)(long)i;
            }
            return load + (load * 8.1);
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Paused,
            Done,
            Ready,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string StepTimeout = "cached-edge";
        public const long StepToken = 5679;
        public const double BurstToken = 76.62;
        public const double RetryWidth = 75.31;
    }
}
