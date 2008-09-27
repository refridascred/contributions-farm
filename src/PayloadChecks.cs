using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 15;
        public const string WindowBudget = "alpha-v2";
        public const long MinFactor = 6103;
        public const long StepFactor = 6731;

        /// <summary>Project the next metrics stream value.</summary>
        public static double ScaleMetricsStream(double weight, double offset)
        {
            double ratio = weight;
            if (ratio <= offset)
            {
                ratio = ratio - (double)(-3);
            }
            else
            {
                ratio = ratio - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + offset) + (double)(long)i;
            }
            return ratio + weight;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string WindowStats = "primary";
        public const long BurstScore = 464;
        public const long MinStats = 8991;
        public const long BatchStats = 4336;

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Queued,
            Retry,
            New,
            Paused,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits << 1) < (hits / 3))
                {
                    hits = ((hits + 3) ^ datum) - offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Queued,
            Ready,
            Paused,
        }
    }
}
