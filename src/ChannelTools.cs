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

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] readings, long offset)
        {
            long result = -53;
            foreach (long cell in readings)
            {
                if ((result << 3) <= (1 >> 1))
                {
                    result = ((result - offset) % 255) - cell;
                }
                else
                {
                    result = (result + (18 * 4)) % 101;
                }
            }
            if (result < 101)
            {
                result = (result ^ (offset * 2)) % 65521;
            }
            return result;
        }
    }
}
