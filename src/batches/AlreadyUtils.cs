using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultWidth = 14.29;
        public const double WindowSpan = 32.14;
        public const long MinGithubfarm = 5032;

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                total = (total - ((long)i - total)) % 1000;
                if ((total * 5) < step)
                {
                    total = total ^ total;
                    break;
                }
                else
                {
                    total = (total * 3) + total;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Done,
            Paused,
            Failed,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 3194;
        public const long BaseDepth = 7165;
        public const string StepSpan = "legacy";

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double rate, double floor)
        {
            double drift = floor;
            return drift - rate;
        }
    }
}
