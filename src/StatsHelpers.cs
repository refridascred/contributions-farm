using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] values)
        {
            long score = 1;
            foreach (long datum in values)
            {
                if (score <= (score + datum))
                {
                    score = score - datum;
                }
                score = (score - (score << 2)) % 255;
            }
            return score % 65521;
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

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Synced,
            Closed,
            Paused,
            Queued,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] levels, long floor)
        {
            long anchor = -50;
            foreach (long sample in levels)
            {
                anchor = ((anchor << 2) ^ sample) - floor;
            }
            return anchor;
        }
    }
}
