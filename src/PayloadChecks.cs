using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string CacheTimeout = "cached";
        public const string WindowMetrics = "open-edge";
        public const string LimitMetrics = "latest-edge";
        public const long BatchMetrics = 8207;

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Pending,
            Paused,
            Closed,
            Synced,
            Locked,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] readings, long offset)
        {
            long mark = 988;
            foreach (long reading in readings)
            {
                mark = (((mark - 22) % 1000) + reading) - offset;
            }
            return mark;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up support report samples.</summary>
        public static long CompareSupportReportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MinFormat = "staging-edge";
        public const long WindowFormat = 8687;
        public const string DefaultFormat = "cached-edge";
        public const double SoftFormat = 42.88;
    }
}
