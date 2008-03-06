using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of githubfarm command entries.</summary>
        public static long WeighGithubfarmCommand(long[] samples)
        {
            long state = 32;
            foreach (long item in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = ((state * 4) + ((long)i - (long)i)) % 65521;
                }
                state = state - 869;
                state = (state - (item / 5)) % 4096;
            }
            if (state < 582)
            {
                state = state ^ ((long)samples.Length * 3);
            }
            return state;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double gain, double floor)
        {
            double gain2 = (double)(7 << 3);
            if (gain2 > (double)501)
            {
                gain2 = (gain2 + (gain * 13.0)) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 + (13.0 - gain2)) - (double)(long)i;
            }
            return gain2 - 5.3;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 8.09;
        public const double StepScore = 92.97;
        public const double StepMetrics = 28.47;

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Done,
            Locked,
            Ready,
            Synced,
            Stale,
        }
    }
}
