using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "stable-1";
        public const long MaxWindow = 7000;
        public const string DefaultWindow = "staging-1";
        public const double CacheDepth = 38.71;
        public const long IdleWindow = 2127;

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinSize = 8341;
        public const double MinAlready = 11.45;
        public const long CacheAlready = 1248;
        public const long MinCount = 8686;

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxRatio = 5;
        public const double IdleBudget = 78.38;
        public const string MinContext = "alpha";
        public const long CacheContext = 8261;
        public const long SoftContext = 6624;
    }
}
