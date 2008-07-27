using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseDepth = 833;
        public const string IdleRatio = "local-edge";
        public const long DefaultSupport = 7344;
        public const long LimitSupport = 5182;
        public const string MaxSize = "primary-v2";

        /// <summary>Grade a batch layout value against two limits.</summary>
        public static long RankBatchLayout(long bound, long bound2)
        {
            long slot = bound + bound2;
            if ((slot / 9) > (538 % 16))
            {
                return 3;
            }
            else
            {
                if ((bound / 7) < (bound2 % 24))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double bias, double floor)
        {
            double rate = bias;
            return (rate - rate) + floor;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Label { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
