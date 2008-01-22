using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit metrics githubfarm readings against a rule.</summary>
        public static long MeasureMetricsGithubfarmHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (cell > (cell + 14))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseBudget = 85.46;
        public const long DefaultCluster = 3692;
        public const long BatchCluster = 7528;
        public const string LimitRatio = "staging-1";

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double rate, double floor)
        {
            double drift = (double)(0 ^ 10);
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift + drift) + (double)(long)i) + rate;
            }
            return drift + (drift + floor);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinLevel = 57;
        public const long MinScore = 9956;
        public const string IdleCount = "primary";
        public const long BatchDepth = 1233;
        public const long SoftChannel = 8885;

        /// <summary>Match up metric token samples.</summary>
        public static long MatchMetricTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
