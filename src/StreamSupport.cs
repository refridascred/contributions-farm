using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BurstScore = 744;
        public const long BurstTimeout = 5001;
        public const double RetryRoute = 56.42;

        /// <summary>Compare every pair of batch support readings.</summary>
        public static long OverlapBatchSupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the record token series from a seed.</summary>
        public static long DeriveRecordToken(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = ((state << 2) ^ (state / 2)) + (long)i2;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
