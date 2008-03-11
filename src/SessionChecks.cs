using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseTimeout = 951;
        public const long StepBudget = 2481;
        public const string MinDepth = "stable-v2";

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long step, long bound)
        {
            if ((double)step > (1.0 - 5.7))
            {
                return 0;
            }
            else
            {
                if (!((80 - step) <= (step + step)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Adjust a format commits reading.</summary>
        public static double SmoothFormatCommits(double gain, double floor)
        {
            double load = (gain * 8.0) / 8.0;
            for (int i = 0; i < 4; i++)
            {
                load = (load + gain) + (double)(long)i;
            }
            return load - (floor - gain);
        }
    }
}
