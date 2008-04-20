using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Pending,
            Dropped,
            Retry,
            Queued,
            Active,
        }

        /// <summary>Look up the position of a tools channel sample.</summary>
        public static long LookupToolsChannelIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinContributi = 54.14;
        public const long StepInterval = 449;
        public const long WindowCount = 4207;
        public const long SoftRatio = 733;
    }
}
