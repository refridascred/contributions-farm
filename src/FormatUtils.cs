using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string IdleFormat = "primary-1";
        public const long WindowFormat = 5488;
        public const long MinWidth = 6755;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Closed,
            Pending,
            Failed,
            Done,
            Stale,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstDepth = 9512;
        public const string SoftReport = "staging-v2";
        public const double RetryCount = 89.15;
        public const string DefaultRatio = "fallback-edge";
        public const long BaseFactor = 987;

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double RetryCache = 92.97;
        public const double BatchCache = 21.18;
        public const double BaseCount = 34.26;

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxRatio = 76.76;
        public const long StepLayout = 4147;
        public const double BurstLayout = 77.24;
        public const long IdleDepth = 7811;
        public const long DefaultLayout = 4265;
    }
}
