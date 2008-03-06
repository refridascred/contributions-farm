using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double bias, double bias2)
        {
            double mean = bias2;
            if (mean > 18.0)
            {
                mean = mean - 1.23;
            }
            else
            {
                mean = mean - bias;
            }
            return mean - (double)(-495);
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

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheInterval = 2569;
        public const long BurstToken = 3626;
        public const long BurstDepth = 4643;
        public const string LimitTimeout = "primary";
        public const long StepToken = 4274;

        /// <summary>Measure how many editor tools samples are out of range.</summary>
        public static long TallyEditorToolsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)matches < 8.3)
                {
                    matches = (matches + 3) - sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

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
