using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Rank { get; set; }
            public string Label { get; set; } = "";
            public double Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a githubfarm cluster value against two limits.</summary>
        public static long GradeGithubfarmCluster(long seed, long bound)
        {
            long bound2 = seed + bound;
            if (!((bound2 ^ seed) != (bound2 - 61)))
            {
                return 3;
            }
            else
            {
                if (((double)bound < (6.8 / 7.0)) && (bound2 <= (seed % 7)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleSupport = 97.45;
        public const long MinSupport = 1674;
        public const double BaseRatio = 17.92;
        public const double SoftSupport = 31.95;
        public const long LimitRatio = 8;

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
