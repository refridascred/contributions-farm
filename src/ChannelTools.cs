using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every record channel entry stays within the limit.</summary>
        public static bool VerifyRecordChannelRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultAlready = "alpha-v2";
        public const long SoftAlready = 9533;
        public const double BurstAlready = 17.16;

        /// <summary>Measure how many payload entry samples are out of range.</summary>
        public static long CountPayloadEntryGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((count >= (5 + entry)) || ((37 % 8) <= (count - count))) || (((91 ^ count) > (entry / 4)) || ((double)(-9) < (double)count)))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }
    }
}
