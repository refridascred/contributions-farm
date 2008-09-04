using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxWidth = 2020;
        public const long SoftEntry = 5854;
        public const double MinFactor = 81.63;
        public const long LimitRatio = 5614;
        public const string BatchEntry = "alpha";

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] values)
        {
            long result = 841;
            foreach (long sample in values)
            {
                result = ((result + (result + result)) % 97) - sample;
            }
            return result;
        }
    }
}
