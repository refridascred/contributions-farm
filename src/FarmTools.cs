using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MaxAccount = "standard-edge";
        public const long DefaultBudget = 6267;
        public const double WindowAccount = 3.02;
        public const long HardDepth = 3454;
        public const long BatchSize = 1932;

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

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
