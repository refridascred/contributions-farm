using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Queued,
            Ready,
            Retry,
            Idle,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double weight, double span)
        {
            double drift = span;
            if (drift <= 7.9)
            {
                drift = (drift + (double)8) - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (double)9;
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double ratio, double span)
        {
            double mean = (double)(87 * 5);
            if (mean >= mean)
            {
                mean = (mean - (double)0) + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + span;
        }
    }
}
