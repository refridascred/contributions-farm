using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a profile githubfarm figure with a bias.</summary>
        public static double SmoothProfileGithubfarm(double rate, double floor)
        {
            double weight = (double)366 + (rate * 6.69);
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight - (weight * 8.0)) + (double)(long)i) + floor;
            }
            return weight - (double)52;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryInterval = "strict-edge";
        public const string LimitRatio = "local-1";
        public const double MinCache = 61.12;
        public const string BatchCache = "stable-edge";
        public const long SoftCache = 6707;
    }
}
