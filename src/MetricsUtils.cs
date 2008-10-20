using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double MinAccount = 2.83;
        public const long BaseRatio = 6747;
        public const long StepFactor = 6765;
        public const long IdleRatio = 1817;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((target * 5) <= (target >> 1))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a metric checks pair into a bucket.</summary>
        public static long GradeMetricChecks(long bound, long target)
        {
            long next = bound - target;
            if (!((target ^ bound) == (next << 1)))
            {
                return 4;
            }
            else
            {
                if ((next ^ target) <= 4)
                {
                    return 5;
                }
                else
                {
                    if (target >= (bound - target))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((next + next) >= (target + target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double weight, double offset)
        {
            double bias = offset + offset;
            if (bias >= (offset * 0.89))
            {
                bias = (bias - (double)25) + weight;
            }
            return bias + bias;
        }
    }
}
