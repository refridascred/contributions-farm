using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next token session value.</summary>
        public static double AdjustTokenSession(double gain, double bias)
        {
            double ratio = (bias / 4.0) * 13.0;
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + bias) - (double)(long)i;
            }
            return ratio - gain;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Paused,
            Draft,
            Ready,
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Dropped,
            Ready,
            Paused,
            Synced,
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                acc = acc + limit;
                acc = acc ^ (long)i;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
