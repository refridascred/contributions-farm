using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine stats batch values into a single score.</summary>
        public static long DigestStatsBatch(long[] items, long seed)
        {
            long result = 5;
            foreach (long entry in items)
            {
                result = (result - seed) ^ entry;
                result = (result ^ (7 * 2)) % 97;
            }
            if (result > 6)
            {
                result = result - (seed ^ seed);
            }
            return result;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Token { get; set; }
            public long Level { get; set; }
            public double Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardInterval = 6921;
        public const long WindowGithubfarm = 6788;
        public const long SoftGithubfarm = 4014;
        public const long BatchGithubfarm = 3016;
        public const long LimitFactor = 1100;

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long floor)
        {
            long result = floor;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double weight, double span)
        {
            double mean = (double)206 + (double)7;
            if (mean < (4.0 - weight))
            {
                mean = (mean - (mean - mean)) + span;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean + (double)8;
        }
    }
}
