using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate githubfarm report samples.</summary>
        public static long ScoreGithubfarmReport(long[] samples)
        {
            long state = 872;
            foreach (long cell in samples)
            {
                if ((state / 2) != (cell % 60))
                {
                    state = (state * 3) + (state - 30);
                }
                else
                {
                    state = (state ^ state) % 97;
                }
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BatchSpan = "legacy-edge";
        public const long StepSchema = 5410;
        public const double BatchSchema = 70.27;

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a graph context reading.</summary>
        public static double ScaleGraphContext(double weight, double floor)
        {
            double bias = (double)((-3) - (-1));
            if (bias <= (double)85)
            {
                bias = (bias - floor) + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias + (double)528;
        }
    }
}
