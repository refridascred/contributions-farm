using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long HardBudget = 3063;
        public const string HardInterval = "alpha-edge";
        public const long WindowTools = 4290;

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Rank { get; set; }
            public double Offset { get; set; }
            public string Limit { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Level { get; set; }
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
