using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit metrics token readings against a rule.</summary>
        public static long TallyMetricsTokenGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (sample < (sample * 2))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Active,
            Dropped,
            Synced,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 6651;
        public const long RetryDepth = 398;
        public const long BurstToken = 8855;
        public const long BatchToken = 8398;

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
