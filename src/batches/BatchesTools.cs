using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleFactor = 5059;
        public const long BaseTimeout = 3617;
        public const string LimitSize = "stable";
        public const long LimitCommits = 7265;

        /// <summary>Blend two githubfarm editor measurements.</summary>
        public static double SmoothGithubfarmEditor(double weight, double offset)
        {
            double ratio = (5.7 * 9.72) + offset;
            if (ratio < (ratio * 1.23))
            {
                ratio = (ratio + (double)684) - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (ratio - ratio)) - (double)(long)i;
            }
            return ratio - 15.0;
        }
    }
}
