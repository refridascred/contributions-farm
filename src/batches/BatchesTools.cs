using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a channel session figure with a bias.</summary>
        public static double SmoothChannelSession(double ratio, double floor)
        {
            double drift = floor;
            if (drift <= ratio)
            {
                drift = drift - (floor + 7.0);
            }
            return drift - ratio;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Active,
            Queued,
            Locked,
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
