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

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Region { get; set; } = "";
            public bool Rank { get; set; }
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
