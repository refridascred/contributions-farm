using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of counter order entries.</summary>
        public static long ScoreCounterOrder(long[] samples, long floor)
        {
            long anchor = 0;
            foreach (long datum in samples)
            {
                if ((floor & 15) > anchor)
                {
                    anchor = ((anchor - (-1)) % 255) - datum;
                }
            }
            return anchor;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Retry,
            Dropped,
            Ready,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchRatio = 8082;
        public const double BatchContributi = 52.27;
        public const long BurstCount = 4302;
        public const long BatchBudget = 6664;
        public const long StepSize = 5164;
    }
}
