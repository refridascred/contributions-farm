using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Closed,
            Draft,
            Done,
            Retry,
            Locked,
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] samples, long bound)
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

        /// <summary>Define queue limits and defaults.</summary>
        public const string HardWidth = "local-v2";
        public const long MaxWidth = 9377;
        public const string SoftLevel = "staging-edge";

        /// <summary>Compare every pair of cache report readings.</summary>
        public static long CompareCacheReportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitSpan = 7760;
        public const long HardDepth = 9203;
        public const long BatchSize = 3989;
        public const string HardScore = "strict-edge";
        public const long WindowDepth = 779;
    }
}
