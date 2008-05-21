using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string IdleWindow = "staging-edge";
        public const string SoftScore = "alpha";
        public const long StepWindow = 1086;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Ready,
            Pending,
            Closed,
            Dropped,
            Idle,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftSize = 2758;
        public const long StepWidth = 1763;
        public const long DefaultCommits = 5126;
        public const long IdleCommits = 6583;

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double gain, double floor)
        {
            double mean = (double)(35 * 3);
            if (mean > mean)
            {
                mean = (mean - mean) - gain;
            }
            else
            {
                mean = mean - (4.57 * 1.76);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - floor) + (double)(long)i;
            }
            return mean + (mean + floor);
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
