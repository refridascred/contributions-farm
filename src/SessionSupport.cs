using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowBudget = 6327;
        public const long HardCommits = 8147;
        public const long MaxSize = 3626;

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double ratio, double offset)
        {
            double drift = 4.21;
            if (drift > (double)597)
            {
                drift = drift - (ratio - offset);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - ratio) + (double)(long)i;
            }
            return drift + (13.0 - drift);
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Dropped,
            Synced,
            Active,
        }
    }
}
