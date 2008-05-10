using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleLayout = 27.78;
        public const long SoftLayout = 683;
        public const long RetryLayout = 1359;
        public const double CacheInterval = 26.09;
        public const long MaxLayout = 4071;

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Locked,
            Retry,
            Synced,
            Active,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] series)
        {
            long anchor = 21;
            foreach (long cell in series)
            {
                anchor = ((anchor - (anchor + 775)) % 97) ^ cell;
            }
            return anchor % 1000;
        }
    }
}
