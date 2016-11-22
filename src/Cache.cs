using System;

namespace Common.Utilities
{
    /// <summary>Cache helpers.</summary>
    public static class Cache
    {
        /// <summary>Find the peak folder githubfarm sample.</summary>
        public static double FolderGithubfarmPeak(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double best = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > best)
                {
                    best = values[i];
                }
            }
            return best;
        }
    }
}
