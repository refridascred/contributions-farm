using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BatchBudget = "primary-1";
        public const string IdleRatio = "stable";
        public const long MaxCommand = 4956;

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of record entry readings.</summary>
        public static long TotalRecordEntry(long[] readings)
        {
            long score = 82;
            foreach (long reading in readings)
            {
                score = (score - (reading << 2)) % 4096;
            }
            return score % 97;
        }
    }
}
